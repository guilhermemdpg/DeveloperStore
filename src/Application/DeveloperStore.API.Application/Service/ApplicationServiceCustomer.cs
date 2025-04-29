using DeveloperStore.API.Application.DTO;
using DeveloperStore.API.Application.Interfaces;
using DeveloperStore.Domain.Core.Interfaces.Services;
using DeveloperStore.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DeveloperStore.API.Application.Service
{
    public class ApplicationServiceCustomer : IApplicationServiceCustomer
    {
        private readonly IServiceCustomer _serviceCustomer;
        private readonly IMapperCustomer _mapperCustomer;
     
        public ApplicationServiceCustomer(IServiceCustomer ServiceCustomer
                                                 , IMapperCustomer MapperCustomer)
                                              
        {
            _serviceCustomer = ServiceCustomer;
            _mapperCustomer = MapperCustomer;
        }


        public void Add(CustomerDTO obj)
        {
            var objCustomer = _mapperCustomer.MapperToEntity(obj);
            _serviceCustomer.Add(objCustomer);
        }

        public void Dispose()
        {
            _serviceCustomer.Dispose();
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            var objSaleItem = _serviceCustomer.GetAll();
            return _mapperCustomer.MapperListCustomer((IEnumerable<Domain.Entities.Customer>)objSaleItem);
        }

        public CustomerDTO GetById(int id)
        {
            var objcustomer = _serviceCustomer.GetById(id);
            return _mapperCustomer.MapperToDTO((Domain.Entities.Customer)objcustomer);
        }

        public void Remove(CustomerDTO obj)
        {
            var objCustomer = _mapperCustomer.MapperToEntity(obj);
            _serviceCustomer.Remove(objCustomer);
        }

        public void Update(CustomerDTO obj)
        {
            var objCustomer = _mapperCustomer.MapperToEntity(obj);
            _serviceCustomer.Update(objCustomer);
        }
    }
}