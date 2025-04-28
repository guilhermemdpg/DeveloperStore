using DeveloperStore.API.Application.DTO;
using System.Collections.Generic;

namespace DeveloperStore.API.Application.Interfaces
{
    public interface IApplicationServiceCustomer
    {
        void Add(CustomerDTO obj);

        CustomerDTO GetById(int id);

        IEnumerable<CustomerDTO> GetAll();

        void Update(CustomerDTO obj);

        void Remove(CustomerDTO obj);

        void Dispose();

    }
}