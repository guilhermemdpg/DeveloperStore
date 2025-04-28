using DeveloperStore.API.Application.DTO;
using DeveloperStore.Domain.Entities;
using System.Collections.Generic;

namespace DeveloperStore.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperSaleItem
    {
        #region Interfaces Mappers
        SaleItem MapperToEntity(SaleItemDTO saleitemDTO);

        IEnumerable<SaleItemDTO> MapperListSaleItem(IEnumerable<SaleItem> saleitem);

        SaleItemDTO MapperToDTO(SaleItem saleitem);

        #endregion

    }
}