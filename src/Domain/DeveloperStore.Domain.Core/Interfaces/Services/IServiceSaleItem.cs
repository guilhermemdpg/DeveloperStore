using System.Collections.Generic;
using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Domain.Core.Interfaces.Services
{
    public interface IServiceSaleItem : IServiceBase<SaleItem>
    {
        new void Add(SaleItem obj);
        new SaleItem GetById(int id);
        new IEnumerable<SaleItem> GetAll();
        new void Update(SaleItem obj);
        new void Remove(SaleItem obj);
        new void Dispose();
    }
}