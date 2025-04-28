using DeveloperStore.API.Application.DTO;
using DeveloperStore.Domain.Entities;
using System.Collections.Generic;

namespace DeveloperStore.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperSale
    {
        #region Interfaces Mappers
        Sale MapperToEntity(SaleDTO saleDTO);

        IEnumerable<SaleDTO> MapperListSale(IEnumerable<Sale> sale);

        SaleDTO MapperToDTO(Sale sale);

        #endregion

    }
}