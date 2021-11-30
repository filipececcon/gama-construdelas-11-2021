using System;
using Construdelas.OrderSystem.Application.Commands;
using Construdelas.OrderSystem.Application.Commands.interfaces;
using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Queries;
using Construdelas.OrderSystem.Application.Queries.Interfaces;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;
using Construdelas.OrderSystem.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Construdelas.OrderSystem.Services.API
{
    public class ServiceRegister
    {
        public static void Register(IServiceCollection services)
        {
            RegisterRepositories(services);
            RegisterCommands(services);
            RegisterQueries(services);
        }

        private static void RegisterCommands(IServiceCollection services)
        {
            services.AddSingleton<IAddProductCommand, AddProductCommand>();
            services.AddSingleton<IUpdateProductCommand, UpdateProductCommand>();
            services.AddSingleton<IRemoveProductByIdCommand, RemoveProductByIdCommand>();


            services.AddSingleton<IAddOrderCommand, AddOrderCommand>();
            



            services.AddSingleton(typeof(IChangeStatusCommand<>), typeof(ChangeStatusCommand<>));
        }

        private static void RegisterQueries(IServiceCollection services)
        {
            services.AddSingleton<IGetProductByIdQuery, GetProductByIdQuery>();
            services.AddSingleton<IGetAllProductQuery, GetAllProductQuery>();
            services.AddSingleton<IGetAllOrderQuery, GetAllOrderQuery>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
