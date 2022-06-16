using ErpDashboard.Application.Features.Products.Commands.AddEdit;
using ErpDashboard.Application.Interfaces.Repositories;
using FluentValidation;
using ErpDashboard.Domain.Entities.Catalog;
using Microsoft.Extensions.Localization;
using System.Linq;

namespace ErpDashboard.Application.Validators.Features.Products.Commands.AddEdit
{
    public class AddEditProductCommandValidator : AbstractValidator<AddEditProductCommand>
    {
       
        public AddEditProductCommandValidator(IStringLocalizer<AddEditProductCommandValidator> localizer, IUnitOfWork<int> unitOfWork)
        {
            RuleFor(request => request.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);
              
            RuleFor(request => request.Barcode)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Barcode is required!"]);
            RuleFor(request => request.Description)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Description is required!"]);
            RuleFor(request => request.BrandId)
                .GreaterThan(0).WithMessage(x => localizer["Brand is required!"]);
            RuleFor(request => request.Rate)
                .GreaterThan(0).WithMessage(x => localizer["Rate must be greater than 0"]);
            
        }
    
    }
}