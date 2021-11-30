using System;
namespace Construdelas.OrderSystem.Application.Requests
{
    public class RemoveOrderItemRequest
    {
        public RemoveOrderItemRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
