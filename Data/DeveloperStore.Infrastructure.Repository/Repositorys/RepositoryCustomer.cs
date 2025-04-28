using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using DeveloperStore.Domain.Entities;
using DeveloperStore.Infrastructure.Data;

namespace DeveloperStore.Infrastructure.Repository.Repositorys
{
    public class RepositoryCustomer : RepositoryBase<Customer>, IRepositoryCustomer
    {
        private readonly SqlContext _context;
        public RepositoryCustomer(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}