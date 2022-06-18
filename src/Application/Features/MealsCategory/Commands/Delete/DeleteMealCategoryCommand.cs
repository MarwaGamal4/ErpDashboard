using ErpDashboard.Application.Interfaces.Repositories;
using ErpDashboard.Application.Models;
using ErpDashboard.Domain.Entities.Catalog;
using ErpDashboard.Shared.Constants.Application;
using ErpDashboard.Shared.Wrapper;
using MediatR;
using Microsoft.Extensions.Localization;
using System.Threading;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Features.MealCategory.Commands.Delete
{
    public class DeleteMealCategoryCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }

    internal class DeleteMealCategoryCommandHandler : IRequestHandler<DeleteMealCategoryCommand, Result<int>>
    {
        private readonly IMealCategoryRepository _mealCategoryRepository;
        private readonly IStringLocalizer<DeleteMealCategoryCommandHandler> _localizer;
        private readonly ICustomIUnitOfWork<int> _unitOfWork;
        public DeleteMealCategoryCommandHandler(ICustomIUnitOfWork<int> unitOfWork, IMealCategoryRepository mealCategoryRepository, IStringLocalizer<DeleteMealCategoryCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mealCategoryRepository = mealCategoryRepository;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(DeleteMealCategoryCommand command, CancellationToken cancellationToken)
        {
            var isMealCatUsed = await _mealCategoryRepository.IsMealCatUsed(command.Id);
            if (!isMealCatUsed)
            {
                var MealCat = await _unitOfWork.Repository<TbMealsCategory>().GetByIdAsync(command.Id);
                if (MealCat != null)
                {
                    await _unitOfWork.Repository<TbMealsCategory>().DeleteAsync(MealCat);
                    await _unitOfWork.Commit(cancellationToken);
                    return await Result<int>.SuccessAsync(MealCat.Id, _localizer["Meal Category Deleted"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Meal Category Not Found!"]);
                }
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Deletion Not Allowed"]);
            }
        }
    }
}