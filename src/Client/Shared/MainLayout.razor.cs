﻿using ErpDashboard.Application.Features.Companies.GetAllCompanies.Dto;
using ErpDashboard.Client.Extensions;
using ErpDashboard.Client.Infrastructure.Managers.Compaies;
using ErpDashboard.Client.Infrastructure.Managers.Identity.Roles;
using ErpDashboard.Client.Infrastructure.Settings;
using ErpDashboard.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.JSInterop;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ErpDashboard.Client.Shared
{
    public partial class MainLayout : IDisposable
    {
        [Inject] private IRoleManager RoleManager { get; set; }
        [Inject] private ICompanyManager companyManager { get; set; }
        private string CurrentUserId { get; set; }
        private string ImageDataUrl { get; set; }
        private string FirstName { get; set; }
        private string SecondName { get; set; }
        private string Email { get; set; }
        private int _currentCompany { get; set; }
        private char FirstLetterOfName { get; set; }
        private string CompanyName { get; set; } = "";
        private List<GetAllCompaniesDto>CompaniesList {get;set;}
        private async Task LoadDataAsync()
        {
            var state = await _stateProvider.GetAuthenticationStateAsync();
            var user = state.User;
            
            if (user == null) return;
            if (user.Identity?.IsAuthenticated == true)
            {
                CurrentUserId = user.GetUserId();
                FirstName = user.GetFirstName();
                SecondName = user.GetLastName();
                Email = user.GetEmail();
                var imageResponse = await _accountManager.GetProfilePictureAsync(CurrentUserId);
                if (imageResponse.Succeeded)
                {
                    ImageDataUrl = imageResponse.Data;
                }
              
                var currentUserResult = await _userManager.GetAsync(CurrentUserId);

                if (!currentUserResult.Succeeded || currentUserResult.Data == null)
                {
                    _snackBar.Add(localizer["You are logged out because the user with your Token has been deleted."], Severity.Error);
                    await _authenticationManager.Logout();
                }

                await hubConnection.SendAsync(ApplicationConstants.SignalR.OnConnect, CurrentUserId);
            }
        }
        Func<int, string> CompanyStringconverter()
        {
            return p => $"{CompaniesList.FirstOrDefault(x => x.CompanyId == p).CompanySympol}|{CompaniesList.FirstOrDefault(x => x.CompanyId == p).CompanyName}";
        }
        private MudTheme _currentTheme;
        private bool _drawerOpen = true;
        private bool _rightToLeft = false;
        private async Task LoadCompanies() 
        {
            var response = await companyManager.GetAllAsync();
            if (response.Succeeded)
            {
                CompaniesList = response.Data;
                if (_currentCompany == 0)
                {
                    _currentCompany = CompaniesList.FirstOrDefault().CompanyId;
                }
                CompanyName = CompaniesList.FirstOrDefault(x => x.CompanyId == _currentCompany).CompanyName;
                StateHasChanged();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }
        private async Task SetCompany() 
        {
            await _localStorage.SetItemAsync<int>("Company", _currentCompany);
            _navigationManager.NavigateTo(_navigationManager.Uri, true);
        }
        private async Task RightToLeftToggle()
        {
            var isRtl = await _clientPreferenceManager.ToggleLayoutDirection();
            _rightToLeft = isRtl;
            _drawerOpen = false;
        }

        protected override async Task OnInitializedAsync()
        {
            _currentTheme = BlazorHeroTheme.DefaultTheme;
            _currentTheme = await _clientPreferenceManager.GetCurrentThemeAsync();
            _rightToLeft = await _clientPreferenceManager.IsRTL();
            _interceptor.RegisterEvent();
            hubConnection = hubConnection.TryInitialize(_navigationManager);
            await hubConnection.StartAsync();
            hubConnection.On<string, string, string>(ApplicationConstants.SignalR.ReceiveChatNotification, (message, receiverUserId, senderUserId) =>
            {
                if (CurrentUserId == receiverUserId)
                {
                    _jsRuntime.InvokeAsync<string>("PlayAudio", "notification");
                    _snackBar.Add(message, Severity.Info, config =>
                    {
                        config.VisibleStateDuration = 10000;
                        config.HideTransitionDuration = 500;
                        config.ShowTransitionDuration = 500;
                        config.Action = localizer["Chat?"];
                        config.ActionColor = Color.Primary;
                        config.Onclick = snackbar =>
                        {
                            _navigationManager.NavigateTo($"chat/{senderUserId}");
                            return Task.CompletedTask;
                        };
                    });
                }
            });
            hubConnection.On(ApplicationConstants.SignalR.ReceiveRegenerateTokens, async () =>
            {
                try
                {
                    var token = await _authenticationManager.TryForceRefreshToken();
                    if (!string.IsNullOrEmpty(token))
                    {
                        _snackBar.Add(localizer["Refreshed Token."], Severity.Success);
                        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    _snackBar.Add(localizer["You are Logged Out."], Severity.Error);
                    await _authenticationManager.Logout();
                    _navigationManager.NavigateTo("/");
                }
            });
            hubConnection.On<string, string>(ApplicationConstants.SignalR.LogoutUsersByRole, async (userId, roleId) =>
            {
                if (CurrentUserId != userId)
                {
                    var rolesResponse = await RoleManager.GetRolesAsync();
                    if (rolesResponse.Succeeded)
                    {
                        var role = rolesResponse.Data.FirstOrDefault(x => x.Id == roleId);
                        if (role != null)
                        {
                            var currentUserRolesResponse = await _userManager.GetRolesAsync(CurrentUserId);
                            if (currentUserRolesResponse.Succeeded && currentUserRolesResponse.Data.UserRoles.Any(x => x.RoleName == role.Name))
                            {
                                _snackBar.Add(localizer["You are logged out because the Permissions of one of your Roles have been updated."], Severity.Error);
                                await hubConnection.SendAsync(ApplicationConstants.SignalR.OnDisconnect, CurrentUserId);
                                await _authenticationManager.Logout();
                                _navigationManager.NavigateTo("/login");
                            }
                        }
                    }
                }
            });
        }

        private void Logout()
        {
            var parameters = new DialogParameters
            {
                {nameof(Dialogs.Logout.ContentText), $"{localizer["Logout Confirmation"]}"},
                {nameof(Dialogs.Logout.ButtonText), $"{localizer["Logout"]}"},
                {nameof(Dialogs.Logout.Color), Color.Error},
                {nameof(Dialogs.Logout.CurrentUserId), CurrentUserId},
                {nameof(Dialogs.Logout.HubConnection), hubConnection}
            };

            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true };

            _dialogService.Show<Dialogs.Logout>(localizer["Logout"], parameters, options);
        }

        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        private async Task DarkMode()
        {
            bool isDarkMode = await _clientPreferenceManager.ToggleDarkModeAsync();
            _currentTheme = isDarkMode
                ? BlazorHeroTheme.DefaultTheme
                : BlazorHeroTheme.DarkTheme;
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
            //_ = hubConnection.DisposeAsync();
        }

        private HubConnection hubConnection;
        public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

        protected override async void OnAfterRender(bool firstRender)
        {
            
            if (firstRender)
            {
                var state = await _stateProvider.GetAuthenticationStateAsync();
                var user = state.User;
                var CurrentCompany = await _localStorage.GetItemAsync<int?>("Company");
                if (CurrentCompany == null) _currentCompany = user.GetCompany(); else _currentCompany = CurrentCompany ?? 0;

                if (FirstName.Length > 0)
                {
                    FirstLetterOfName = FirstName[0];
                }
                await LoadCompanies();
            }
             
        }
    }
}