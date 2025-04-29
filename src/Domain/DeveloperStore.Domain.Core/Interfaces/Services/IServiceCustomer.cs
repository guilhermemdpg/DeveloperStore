using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Core.Interfaces.Services
{
    public interface IServiceCustomer : IServiceBase<Customer>
    {
        void Add(Customer obj);
        Customer GetById(int id);
        IEnumerable<Customer> GetAll();
        void Update(Customer obj);
        void Remove(Customer obj);
        void Dispose();
    }
}