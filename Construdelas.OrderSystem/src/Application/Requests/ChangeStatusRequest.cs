using System;
namespace Construdelas.OrderSystem.Application.Requests
{
    public class ChangeStatusRequest
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
    }
}
