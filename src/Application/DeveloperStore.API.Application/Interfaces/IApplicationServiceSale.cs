using DeveloperStore.API.Application.DTO;
using System.Collections.Generic;

namespace DeveloperStore.API.Application.Interfaces
{
    public interface IApplicationServiceSale
    {
        void Add(SaleDTO obj);

        SaleDTO GetById(int id);

        IEnumerable<SaleDTO> GetAll();

        void Update(SaleDTO obj);

        void Remove(SaleDTO obj);

        void Dispose();

    }
}