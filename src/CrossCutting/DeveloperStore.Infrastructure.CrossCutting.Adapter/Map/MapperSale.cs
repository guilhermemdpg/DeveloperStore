using DeveloperStore.API.Application.DTO;
using DeveloperStore.Domain.Entities;
using DeveloperStore.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DeveloperStore.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperSale : IMapperSale
    {

        #region Properties

        List<SaleDTO> saleDTOs = new List<SaleDTO>();

        #endregion

        #region methods

        public Sale MapperToEntity(SaleDTO saleDTO)
        {
            var sale = new Sale(
                customerName: saleDTO.CustomerName,
                branchName: saleDTO.BranchName
            );

            return sale;

        }

        public IEnumerable<SaleDTO> MapperListSale(IEnumerable<Sale> sales)
        {
            foreach (var item in sales)
            {

                SaleDTO saleDTO = new SaleDTO
                {
                    Id = item.Id
                   ,
                    SaleNumber = item.SaleNumber
                   ,
                    SaleDate = item.SaleDate
                  ,
                    CustomerName = item.CustomerName
                  ,
                    TotalAmount = item.TotalAmount
                  ,
                    BranchName = item.BranchName
                  ,
                    IsCancelled = item.IsCancelled
                  ,
                    Items = (List<SaleItemDTO>)item.Items

                };

                saleDTOs.Add(saleDTO);
            }


            return saleDTOs;

        }

        public SaleDTO MapperToDTO(Sale sale)
        {
            SaleDTO saleDTO = new SaleDTO
            {
                  Id = sale.Id
                ,
                  SaleNumber = sale.SaleNumber
                ,
                  SaleDate = sale.SaleDate
                ,
                  CustomerName = sale.CustomerName
                ,
                  TotalAmount = sale.TotalAmount
                ,
                  BranchName = sale.BranchName
                ,
                  IsCancelled = sale.IsCancelled
                ,
                  Items = (List<SaleItemDTO>)sale.Items
            };

            return saleDTO;

        }

        #endregion
    }
}