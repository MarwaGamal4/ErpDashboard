using AutoMapper;
using ErpDashboard.Application.Features.MealsCategory.Queries.Dto;
using ErpDashboard.Application.Interfaces.Repositories;
using ErpDashboard.Application.Models;
using ErpDashboard.Shared.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Features.MealsCategory.Queries.GetById
{
    public class GetMealCategoryByIdQuery : IRequest<Result<GetMealCategoryResponse>>
    {
        public int Id { get; set; }

    }
    internal class GetMealCategoryByIdHandler : IRequestHandler<GetMealCategoryByIdQuery, Result<GetMealCategoryResponse>>
    {
        private readonly ICustomIUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetMealCategoryByIdHandler(ICustomIUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Result<GetMealCategoryResponse>> Handle(GetMealCategoryByIdQuery query, CancellationToken cancellationToken)
        {
            var Cat = await _unitOfWork.Repository<TbMealsCategory>().GetByIdAsync(query.Id);
            var mappedCat = _mapper.Map<GetMealCategoryResponse>(Cat);
            return await Result<GetMealCategoryResponse>.SuccessAsync(mappedCat);
        }
    }
}
