﻿using AutoMapper;
using ErpDashboard.Application.Interfaces.Repositories;
using ErpDashboard.Application.Interfaces.Services;
using ErpDashboard.Domain.Entities.Catalog;
using ErpDashboard.Shared.Constants.Application;
using ErpDashboard.Shared.Wrapper;
using MediatR;
using Microsoft.Extensions.Localization;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Features.Brands.Commands.AddEdit
{
    public partial class AddEditBrandCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Tax { get; set; }
    }

    internal class AddEditBrandCommandHandler : IRequestHandler<AddEditBrandCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditBrandCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly ICurrentUserService _userService;
        public AddEditBrandCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddEditBrandCommandHandler> localizer, ICurrentUserService userService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
            _userService = userService;
        }

        public async Task<Result<int>> Handle(AddEditBrandCommand command, CancellationToken cancellationToken)
        {
            var CompanyID = _userService.CompanyID;
            if (!CompanyID.HasValue)
            {
                return await Result<int>.FailAsync(_localizer["NO COMPANY WITH THIS ID"]);
            }
            if (command.Id == 0)
            {
              
                var brand = _mapper.Map<Brand>(command);
                await _unitOfWork.Repository<Brand>().AddAsync(brand);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllBrandsCacheKey);
                return await Result<int>.SuccessAsync(brand.Id, _localizer["Brand Saved"]);
            }
            else
            {
                var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(command.Id);
                if (brand != null)
                {
                    brand.Name = command.Name ?? brand.Name;
                    brand.Tax = (command.Tax == 0) ? brand.Tax : command.Tax;
                    brand.Description = command.Description ?? brand.Description;
                    await _unitOfWork.Repository<Brand>().UpdateAsync(brand);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllBrandsCacheKey);
                    return await Result<int>.SuccessAsync(brand.Id, _localizer["Brand Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Brand Not Found!"]);
                }
            }
        }
    }
}