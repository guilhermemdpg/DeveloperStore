using DeveloperStore.API.Application.DTO;
using DeveloperStore.API.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DeveloperStore.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly IApplicationServiceSale _applicationServiceSale;

        public SaleController(IApplicationServiceSale ApplicationServiceSale)
        {
            _applicationServiceSale = ApplicationServiceSale;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceSale.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceSale.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] SaleDTO saleDTO)
        {
            try
            {
                if (saleDTO == null)
                    return NotFound();


                _applicationServiceSale.Add(saleDTO);
                return Ok("A compra foi realizada com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] SaleDTO saleDTO)
        {

            try
            {
                if (saleDTO == null)
                    return NotFound();

                _applicationServiceSale.Update(saleDTO);
                return Ok("O carrinho foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] SaleDTO saleDTO)
        {
            try
            {
                if (saleDTO == null)
                    return NotFound();

                _applicationServiceSale.Remove(saleDTO);
                return Ok("A compra foi cancelada com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}