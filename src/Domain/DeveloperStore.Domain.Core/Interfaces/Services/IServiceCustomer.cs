using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Core.Interfaces.Services
{
    public interface IServiceCustomer : IServiceBase<Customer>
    {
        void Add(IServiceCustomer obj);
        IServiceCustomer GetById(int id);
        IEnumerable<IServiceCustomer> GetAll();
        void Update(IServiceCustomer obj);
        void Remove(IServiceCustomer obj);
        void Dispose();
    }
}