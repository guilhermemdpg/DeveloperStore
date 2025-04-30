using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using DeveloperStore.Domain.Core.Interfaces.Services;
using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Services
{
    public class ServiceCustomer : ServiceBase<Customer>, IServiceCustomer
    {
        private readonly IRepositoryCustomer _repositoryCustomer;

        public ServiceCustomer(IRepositoryCustomer repositoryCustomer)
            : base(repositoryCustomer)
        {
            _repositoryCustomer = repositoryCustomer;
        }

        public new void Add(Customer obj)
        {
            _repositoryCustomer.Add(obj);
        }

        public new IEnumerable<Customer> GetAll()
        {
            return _repositoryCustomer.GetAll();
        }

        public new Customer GetById(int id)
        {
            return _repositoryCustomer.GetById(id);
        }

        public new void Remove(Customer obj)
        {
            _repositoryCustomer.Remove(obj);
        }

        public new void Update(Customer obj)
        {
            _repositoryCustomer.Update(obj);
        }
    }
}