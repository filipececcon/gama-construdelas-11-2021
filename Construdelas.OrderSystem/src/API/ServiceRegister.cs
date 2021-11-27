using System;
using Construdelas.OrderSystem.Application.Commands;
using Construdelas.OrderSystem.Application.Interfaces;
using Construdelas.OrderSystem.Application.Queries;
using Construdelas.OrderSystem.Domain.OrderManagement.Interfaces;
using Construdelas.OrderSystem.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Construdelas.OrderSystem.Services.API
{
    public class ServiceRegister
    {
        public static void Register(IServiceCollection services)
        {
            RegisterRespositories(services);
            RegisterCommands(services);
            RegisterQueries(services);
        }

        private static void RegisterCommands(IServiceCollection services)
        {
            services.AddSingleton<IAddProductCommand, AddProductCommand>();
            services.AddSingleton<IUpdateProductCommand, UpdateProductCommand>();
            services.AddSingleton<IRemoveProductByIdCommand, RemoveProductByIdCommand>();
            services.AddSingleton<IProductChangeStatusCommand, ProductChangeStatusCommand>();
        }

        private static void RegisterQueries(IServiceCollection services)
        {
            services.AddSingleton<IGetProductByIdQuery, GetProductByIdQuery>();
            services.AddSingleton<IGetAllProductQuery, GetAllProductQuery>();
        }

        private static void RegisterRespositories(IServiceCollection services)
        {
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IOrderItemRepository, OrderItemRepository>();
            services.AddSingleton<IOrderRepository, OrderRepository>();
        }


    }
}
