using ErpDashboard.Application.Features.MealsCategory.Commands.AddEdit;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Validators.Features.MealsCategory.Commands.AddEdit
{
    public class AddEditMealsCategoryCommandValidator : AbstractValidator<AddEditMealsCategoryCommand>
    {
        public AddEditMealsCategoryCommandValidator(IStringLocalizer<AddEditMealsCategoryCommand> localizer)
        {
            RuleFor(request => request.Name)
           .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required!"]);

            //RuleFor(request => request.IsSnack)
            //    .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Description is required!"]);
            RuleFor(request => request.Symbol)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Symbol is required!"]);
        }
    }
}
