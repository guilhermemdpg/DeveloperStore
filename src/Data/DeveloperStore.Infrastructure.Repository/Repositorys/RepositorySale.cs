using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using DeveloperStore.Domain.Entities;
using DeveloperStore.Infrastructure.Data;

namespace DeveloperStore.Infrastructure.Repository.Repositorys
{
    public class RepositorySale : RepositoryBase<Sale>, IRepositorySale
    {

        private readonly SqlContext _context;
        public RepositorySale(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}