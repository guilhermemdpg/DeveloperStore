using DeveloperStore.API.Application.DTO;
using DeveloperStore.Domain.Entities;
using System.Collections.Generic;

namespace DeveloperStore.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCustomer
    {
        #region Mappers

        Customer MapperToEntity(CustomerDTO customerDTO);

        IEnumerable<CustomerDTO> MapperListCustomer(IEnumerable<Customer> customers);

        CustomerDTO MapperToDTO(Customer Customer);

        #endregion

    }
}