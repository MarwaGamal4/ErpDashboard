using ErpDashboard.Shared.ServerSideValidations.Interfaces;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Shared.ServerSideValidations
{
    public class AddEditProductCommand
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Barcode { get; set; }
        [Required]
        public string Description { get; set; }
        public string ImageDataURL { get; set; }
        [Required]
        public decimal Rate { get; set; }
        [Required]
        public int BrandId { get; set; }
       
    }
    public class AddEditProductCommandValidator : AbstractValidator<AddEditProductCommand>
    {
        private readonly ProductValidationServices _validationServices;
        public AddEditProductCommandValidator(IStringLocalizer<AddEditProductCommandValidator> localizer, ProductValidationServices validationServices)
        {
            RuleFor(request => request.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"])
                .MustAsync(async (x,c) => { return await IsNameExist(x); }).WithMessage("Product Name Is Already Exist");
            RuleFor(request => request.Barcode)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Barcode is required!"]);
            RuleFor(request => request.Description)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Description is required!"]);
            RuleFor(request => request.BrandId)
                .GreaterThan(0).WithMessage(x => localizer["Brand is required!"]);
            RuleFor(request => request.Rate)
                .GreaterThan(0).WithMessage(x => localizer["Rate must be greater than 0"]);
            _validationServices = validationServices;
        }
        private async Task<bool> IsNameExist(string name)
        {
            var result   = await _validationServices.isNameExist(name);
            return !result;
        }
    }

}
