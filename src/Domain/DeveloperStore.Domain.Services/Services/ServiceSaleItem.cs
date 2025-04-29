using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using DeveloperStore.Domain.Core.Interfaces.Services;
using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Services
{
    public class ServiceSaleItem : ServiceBase<SaleItem>, IServiceSaleItem
    {
        private readonly IRepositorySaleItem _repositorySaleItem;

        public ServiceSaleItem(IRepositorySaleItem RepositorySaleItem)
            : base(RepositorySaleItem)
        {
            _repositorySaleItem = RepositorySaleItem;
        }
    }
}