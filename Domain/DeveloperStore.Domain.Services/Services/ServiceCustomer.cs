using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using DeveloperStore.Domain.Core.Interfaces.Services;
using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Services
{
    public class ServiceCustomer : ServiceBase<Customer>, IServiceCustomer
    {
        public readonly IRepositoryCustomer _repositoryCustomer;

        public ServiceCustomer(IRepositoryCustomer RepositoryCustomer)
            : base(RepositoryCustomer)
        {
            _repositoryCustomer = RepositoryCustomer;
        }
    }
}