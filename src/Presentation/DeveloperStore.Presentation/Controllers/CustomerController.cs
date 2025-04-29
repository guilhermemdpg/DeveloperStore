using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperStore.API.Application.DTO;
using DeveloperStore.API.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperStore.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly IApplicationServiceCustomer _applicationServiceCustomer;


        public CustomerController(IApplicationServiceCustomer ApplicationServiceCustomer)
        {
            _applicationServiceCustomer = ApplicationServiceCustomer;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCustomer.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCustomer.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] CustomerDTO customerDTO)
        {
            try
            {
                if (customerDTO == null)
                    return NotFound();

                _applicationServiceCustomer.Add(customerDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] CustomerDTO customerDTO)
        {
            try
            {
                if (customerDTO == null)
                    return NotFound();

                _applicationServiceCustomer.Update(customerDTO);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] CustomerDTO customerDTO)
        {
            try
            {
                if (customerDTO == null)
                    return NotFound();

                _applicationServiceCustomer.Remove(customerDTO);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}