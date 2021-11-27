using Construdelas.OrderSystem.Application.Interfaces;
using Construdelas.OrderSystem.Domain.OrderManagement.Entities;
using Construdelas.OrderSystem.Domain.OrderManagement.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class ProductChangeStatusCommand : ChangeStatusCommand<Product>, IProductChangeStatusCommand
    {
        public ProductChangeStatusCommand(IProductRepository repository) : base(repository)
        {
        }
    }
}
