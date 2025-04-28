using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using DeveloperStore.Domain.Entities;
using DeveloperStore.Infrastructure.Data;

namespace DeveloperStore.Infrastructure.Repository.Repositorys
{
    public class RepositorySaleItem : RepositoryBase<SaleItem>, IRepositorySaleItem
    {

        private readonly SqlContext _context;
        public RepositorySaleItem(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}