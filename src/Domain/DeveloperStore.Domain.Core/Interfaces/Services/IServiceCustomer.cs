using System.Collections.Generic;
using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Core.Interfaces.Services
{
    public interface IServiceCustomer : IServiceBase<Customer>
    {
        new void Add(Customer obj);
        new Customer GetById(int id);
        new IEnumerable<Customer> GetAll();
        new void Update(Customer obj);
        new void Remove(Customer obj);
        new void Dispose();
    }
}