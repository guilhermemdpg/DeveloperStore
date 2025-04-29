using DeveloperStore.API.Application.DTO;
using DeveloperStore.Domain.Entities;
using DeveloperStore.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DeveloperStore.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperSaleItem : IMapperSaleItem
    {

        #region Properties

        List<SaleItemDTO> saleitemDTOs = new List<SaleItemDTO>();

        #endregion

        #region methods

        public SaleItem MapperToEntity(SaleItemDTO saleitemDTO)
        {
            var saleitem = new SaleItem(
                productName: saleitemDTO.ProductName,
                quantity: saleitemDTO.Quantity,
                unitPrice: saleitemDTO.UnitPrice
            );

            return saleitem;

        }

        public IEnumerable<SaleItemDTO> MapperListSaleItem(IEnumerable<SaleItem> saleitems)
        {
            foreach (var item in saleitems)
            {

                SaleItemDTO saleitemDTO = new SaleItemDTO
                {
                    Id = item.Id
                   ,
                    ProductName = item.ProductName
                   ,
                    Quantity = item.Quantity
                  ,
                    UnitPrice = item.UnitPrice
                  ,
                    Discount = item.Discount
                  ,
                    TotalAmount = item.TotalAmount
                  ,
                    IsCancelled = item.IsCancelled

                };

                saleitemDTOs.Add(saleitemDTO);
            }


            return saleitemDTOs;

        }

        public SaleItemDTO MapperToDTO(SaleItem saleitem)
        {
            SaleItemDTO saleitemDTO = new SaleItemDTO
            {
                Id = saleitem.Id
                ,
                ProductName = saleitem.ProductName
                ,
                Quantity = saleitem.Quantity
                ,
                UnitPrice = saleitem.UnitPrice
                ,
                Discount = saleitem.Discount
                ,
                TotalAmount = saleitem.TotalAmount
                ,
                IsCancelled = saleitem.IsCancelled
            };

            return saleitemDTO;

        }

        #endregion
    }
}