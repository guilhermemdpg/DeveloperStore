using DeveloperStore.API.Application.DTO;
using DeveloperStore.API.Application.Interfaces;
using DeveloperStore.Domain.Core.Interfaces.Services;
using DeveloperStore.Infrastructure.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;

namespace DeveloperStore.API.Application.Service
{
    public class ApplicationServiceSale : IDisposable, IApplicationServiceSale
    {
        private readonly IServiceSale _serviceSale;
        private readonly IMapperSale _mapperSale;

        public ApplicationServiceSale(IServiceSale ServiceSale
                                         , IMapperSale MapperSale)
        {
            _serviceSale = ServiceSale;
            _mapperSale = MapperSale;
        }

        public void Add(SaleDTO obj)
        {
            var objSale = _mapperSale.MapperToEntity(obj);
            _serviceSale.Add(objSale);
        }

        public void Dispose()
        {
            _serviceSale.Dispose();
        }

        public IEnumerable<SaleDTO> GetAll()
        {
            var objSale = _serviceSale.GetAll();
            return _mapperSale.MapperListSale((IEnumerable<Domain.Entities.Sale>)objSale);
        }

        public SaleDTO GetById(int id)
        {
            var objSale = _serviceSale.GetById(id);
            return _mapperSale.MapperToDTO((Domain.Entities.Sale)objSale);
        }

        public void Remove(SaleDTO obj)
        {
            var objSale = _mapperSale.MapperToEntity(obj);
            _serviceSale.Remove(objSale);
        }

        public void Update(SaleDTO obj)
        {
            var objSale = _mapperSale.MapperToEntity(obj);
            _serviceSale.Update(objSale);
        }

    }
}