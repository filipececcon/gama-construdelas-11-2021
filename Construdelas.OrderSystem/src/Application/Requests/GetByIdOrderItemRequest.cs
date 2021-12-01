using System;
namespace Construdelas.OrderSystem.Application.Requests
{
    public class GetByIdOrderItemRequest
    {
        public Guid OrderId { get; set; }

        public Guid ItemId { get; set; }
    }
}
