using Construdelas.OrderSystem.Application.Commands.Interfaces;
using Construdelas.OrderSystem.Application.Requests;
using Construdelas.OrderSystem.Application.Responses;
using Construdelas.OrderSystem.Domain.Shared.Entities;
using Construdelas.OrderSystem.Domain.Shared.Interfaces;

namespace Construdelas.OrderSystem.Application.Commands
{
    public class ChangeStatusCommand<TEntity> : IChangeStatusCommand<TEntity> where TEntity : Entity
    {
        private IRepository<TEntity> _repository;

        public ChangeStatusCommand(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public ChangeStatusResponse Handle(ChangeStatusRequest request)
        {
            var entity = _repository.GetById(request.Id);

            entity.IsActive = request.IsActive;

            _repository.Update(entity);

            _repository.Save();

            return new ChangeStatusResponse() { Id = entity.Id, IsActive = entity.IsActive };
        }
    }
}
