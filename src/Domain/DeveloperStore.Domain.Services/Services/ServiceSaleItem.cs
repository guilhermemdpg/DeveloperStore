using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using DeveloperStore.Domain.Core.Interfaces.Services;
using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Services
{
    public class ServiceSaleItem : ServiceBase<SaleItem>, IServiceSaleItem
    {
        private readonly IRepositorySaleItem _repositorySaleItem;

        public ServiceSaleItem(IRepositorySaleItem repositorySaleItem)
            : base(repositorySaleItem)
        {
            _repositorySaleItem = repositorySaleItem;
        }

        public new void Add(SaleItem obj)
        {
            _repositorySaleItem.Add(obj);
        }

        public new IEnumerable<SaleItem> GetAll()
        {
            return _repositorySaleItem.GetAll();
        }

        public new SaleItem GetById(int id)
        {
            return _repositorySaleItem.GetById(id);
        }

        public new void Remove(SaleItem obj)
        {
            _repositorySaleItem.Remove(obj);
        }

        public new void Update(SaleItem obj)
        {
            _repositorySaleItem.Update(obj);
        }
    }
}