using DeveloperStore.API.Application.DTO;
using System.Collections.Generic;

namespace DeveloperStore.API.Application.Interfaces
{
    public interface IApplicationServiceSaleItem
    {
        void Add(SaleItemDTO obj);

        SaleItemDTO GetById(int id);

        IEnumerable<SaleItemDTO> GetAll();

        void Update(SaleItemDTO obj);

        void Remove(SaleItemDTO obj);

        void Dispose();

    }
}