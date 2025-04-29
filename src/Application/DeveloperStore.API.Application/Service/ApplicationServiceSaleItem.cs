using DeveloperStore.API.Application.DTO;
using DeveloperStore.API.Application.Interfaces;
using DeveloperStore.Domain.Core.Interfaces.Services;
using DeveloperStore.Infrastructure.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;

namespace DeveloperStore.API.Application.Service
{
    public class ApplicationServiceSaleItem : IDisposable, IApplicationServiceSaleItem
    {
        private readonly IServiceSaleItem _serviceSaleItem;
        private readonly IMapperSaleItem _mapperSaleItem;

        public ApplicationServiceSaleItem(IServiceSaleItem ServiceSaleItem
                                         , IMapperSaleItem MapperSaleItem)
        {
            _serviceSaleItem = ServiceSaleItem;
            _mapperSaleItem = MapperSaleItem;
        }

        public void Add(SaleItemDTO obj)
        {
            var objSaleItem = _mapperSaleItem.MapperToEntity(obj);
            _serviceSaleItem.Add(objSaleItem);
        }

        public void Dispose()
        {
            _serviceSaleItem.Dispose();
        }

        public IEnumerable<SaleItemDTO> GetAll()
        {
            var objSaleItem = _serviceSaleItem.GetAll();
            return _mapperSaleItem.MapperListSaleItem((IEnumerable<Domain.Entities.SaleItem>)objSaleItem);
        }

        public SaleItemDTO GetById(int id)
        {
            var objSaleItem = _serviceSaleItem.GetById(id);
            return _mapperSaleItem.MapperToDTO((Domain.Entities.SaleItem)objSaleItem);
        }

        public void Remove(SaleItemDTO obj)
        {
            var objSaleItem = _mapperSaleItem.MapperToEntity(obj);
            _serviceSaleItem.Remove(objSaleItem);
        }

        public void Update(SaleItemDTO obj)
        {
            var objSaleItem = _mapperSaleItem.MapperToEntity(obj);
            _serviceSaleItem.Update(objSaleItem);
        }

    }
}