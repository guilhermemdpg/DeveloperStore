using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Core.Interfaces.Services
{
    public interface IServiceSale : IServiceBase<Sale>
    {
        void Add(IServiceSale obj);
        IServiceSale GetById(int id);
        IEnumerable<Sale> GetAll();
        void Update(IServiceSale obj);
        void Remove(IServiceSale obj);
        void Dispose();
    }
}