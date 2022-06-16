using ErpDashboard.Application.Interfaces.Repositories;
using ErpDashboard.Domain.Entities.Catalog;
using ErpDashboard.Shared.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ErpDashboard.Application.Features.Products.Queries.IsExist
{
    public class IsProductExistQuery : IRequest<bool>
    {
        public string Name { get; set; }
    }
    internal class IsProductExistQueryHandler : IRequestHandler<IsProductExistQuery, bool>
    {
        private readonly IUnitOfWork<int> _unitOfWork;

        public IsProductExistQueryHandler(IUnitOfWork<int> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> Handle(IsProductExistQuery request, CancellationToken cancellationToken)
        {
            var result = _unitOfWork.Repository<Product>().Entities.Any(x => x.Name == request.Name);
            return Task.FromResult(result);
        }
    }
}
