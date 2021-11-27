using System;
namespace Construdelas.OrderSystem.Application.Responses
{
    public class ChangeStatusResponse
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
    }
}
