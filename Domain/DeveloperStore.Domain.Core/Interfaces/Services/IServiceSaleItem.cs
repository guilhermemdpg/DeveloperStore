using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Core.Interfaces.Services
{
    public interface IServiceSaleItem : IServiceBase<SaleItem>
    {
        void Add(IServiceSaleItem obj);
        IServiceSaleItem GetById(int id);
        IEnumerable<IServiceSaleItem> GetAll();
        void Update(IServiceSaleItem obj);
        void Remove(IServiceSaleItem obj);
        void Dispose();
    }
}