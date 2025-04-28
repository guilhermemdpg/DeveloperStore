using DeveloperStore.API.Application.DTO;
using DeveloperStore.API.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DeveloperStore.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SaleItemController : ControllerBase
    {
        private readonly IApplicationServiceSaleItem _applicationServiceSaleItem;

        public SaleItemController(IApplicationServiceSaleItem ApplicationServiceSaleItem)
        {
            _applicationServiceSaleItem = ApplicationServiceSaleItem;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceSaleItem.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceSaleItem.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] SaleItemDTO saleitemDTO)
        {
            try
            {
                if (saleitemDTO == null)
                    return NotFound();


                _applicationServiceSaleItem.Add(saleitemDTO);
                return Ok("O produto foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] SaleItemDTO saleitemDTO)
        {

            try
            {
                if (saleitemDTO == null)
                    return NotFound();

                _applicationServiceSaleItem.Update(saleitemDTO);
                return Ok("O produto foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] SaleItemDTO saleitemDTO)
        {
            try
            {
                if (saleitemDTO == null)
                    return NotFound();

                _applicationServiceSaleItem.Remove(saleitemDTO);
                return Ok("O produto foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}