using ErpDashboard.Application.Features.Companies.GetAllCompanies.Dto;
using ErpDashboard.Application.Interfaces.Repositories;
using ErpDashboard.Shared.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ErpDashboard.Application.Models;

namespace ErpDashboard.Application.Features.Companies.GetAllCompanies
{
    public class GetAllCompaniesRequest : IRequest<IResult<List<GetAllCompaniesDto>>>
    {
        public GetAllCompaniesRequest()
        {

        }
    }
    internal class GetAllCompaniesRequestHandler : IRequestHandler<GetAllCompaniesRequest, IResult<List<GetAllCompaniesDto>>>
    {
        private readonly CustomIUnitOfWork<int> _unitOfWork;
        private readonly ICompanyRepository _repository;
        public GetAllCompaniesRequestHandler(CustomIUnitOfWork<int> unitOfWork, ICompanyRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<IResult<List<GetAllCompaniesDto>>> Handle(GetAllCompaniesRequest request, CancellationToken cancellationToken)
        {
            
            var Companies = await _unitOfWork.Repository<TbCompany>().GetAllAsync();
            var MappedCompanies = Companies.Select(c => new GetAllCompaniesDto() { CompanyId = c.ComId, CompanyName = c.ComName, CompanySympol = c.CompanySymbol }).ToList();
            return await Result<List<GetAllCompaniesDto>>.SuccessAsync(MappedCompanies);
        }
    }
}
