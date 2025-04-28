using DeveloperStore.API.Application.DTO;
using DeveloperStore.Domain.Entities;
using DeveloperStore.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DeveloperStore.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperCustomer : IMapperCustomer
    {

        #region properties

        List<CustomerDTO> customerDTOs = new List<CustomerDTO>();

        #endregion


        #region methods

        public Customer MapperToEntity(CustomerDTO customerDTO)
        {
            Customer customer = new Customer
            {
                Id = customerDTO.Id
                ,
                Name = customerDTO.Name
                ,
                Surname = customerDTO.Surname
                ,
                Email = customerDTO.Email
            };

            return customer;

        }


        public IEnumerable<CustomerDTO> MapperListCustomer(IEnumerable<Customer> customers)
        {
            foreach (var item in customers)
            {


                CustomerDTO customerDTO = new CustomerDTO
                {
                    Id = item.Id
                   ,
                    Name = item.Name
                   ,
                    Surname = item.Surname
                   ,
                    Email = item.Email
                };



                customerDTOs.Add(customerDTO);

            }

            return customerDTOs;
        }

        public CustomerDTO MapperToDTO(Customer Customer)
        {

            CustomerDTO customerDTO = new CustomerDTO
            {
                Id = Customer.Id
                ,
                Name = Customer.Name
                ,
                Surname = Customer.Surname
                ,
                Email = Customer.Email
            };

            return customerDTO;

        }

        #endregion

    }
}