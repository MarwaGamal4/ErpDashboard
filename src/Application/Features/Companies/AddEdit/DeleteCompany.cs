using ErpDashboard.Application.Interfaces.Repositories;
using ErpDashboard.Shared.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Features.Companies.AddEdit
{
    public class DeleteCompanyCommand : IRequest<IResult<int>>
    {

    }
    internal class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, IResult<int>>
    {
        private readonly CustomIUnitOfWork<int> _unitOfWork;

        public DeleteCompanyCommandHandler(CustomIUnitOfWork<int> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IResult<int>> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
