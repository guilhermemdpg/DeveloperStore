using System.Collections.Generic;
using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Core.Interfaces.Services
{
    public interface IServiceSale : IServiceBase<Sale>
    {
        new void Add(Sale obj);
        new Sale GetById(int id);
        new IEnumerable<Sale> GetAll();
        new void Update(Sale obj);
        new void Remove(Sale obj);
        new void Dispose();
    }
}