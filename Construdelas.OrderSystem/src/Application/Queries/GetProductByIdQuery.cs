using Construdelas.OrderSystem.Application.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Queries
{
    public class GetProductByIdQuery : IGetProductByIdQuery
    {
        private IRepository<Product> _repository;

        public GetProductByIdQuery(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public GetProductByIdResponse Handle(GetProductByIdRequest request)
        {
            var product = _repository.GetById(request.Id);

            return new GetProductByIdResponse()
            {
                Id = product.Id,
                Name = product.Name,
                CreatedAt = product.CreatedAt,
                UnitValue = product.UnitValue,
                UpdatedAt = product.UpdatedAt,
                IsActive = product.IsActive
            };
        }
    }
}
