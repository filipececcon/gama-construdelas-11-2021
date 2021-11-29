using System;
namespace Construdelas.OrderSystem.Application.Requests
{
    public class GetAllProductRequest
    {
        public bool? IsActive { get; set; }

        public decimal? GteUnitvalue { get; set; }

        public decimal? LteUnitvalue { get; set; }


    }
}
