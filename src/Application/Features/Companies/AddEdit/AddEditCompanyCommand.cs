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
    public class AddEditCompanyCommand : IRequest<IResult<int>>
    {
        
    }
    internal class AddEditCompanyCommandHandler : IRequestHandler<AddEditCompanyCommand, IResult<int>>
    {
        private readonly CustomIUnitOfWork<int> _unitOfWork;

        public AddEditCompanyCommandHandler(CustomIUnitOfWork<int> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IResult<int>> Handle(AddEditCompanyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
