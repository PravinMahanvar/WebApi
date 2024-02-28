using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using WebAPIProject.Models;

namespace WebApi.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices service;
        public ProductController(IProductServices Service)
        {
            this.service = Service;
        }
        [HttpGet]
        [Route("GetProducts")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var list = await service.GetProducts();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetProductById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var model = await service.GetProductById(id);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("AddProduct")]
        public async Task<IActionResult> Post([FromBody][Bind(include: "P_name,Price,image")] Product product)
        {
            try
            {
                var result = await service.AddProduct(product);
                if (result >= 1)
                    return StatusCode(StatusCodes.Status201Created);
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPut]
        [Route("UpdateProduct")]
        public async Task<IActionResult> Put([FromBody] Product product)
        {
            try
            {
                var result = await service.UpdateProduct(product);
                if (result >= 1)
                    return StatusCode(StatusCodes.Status201Created);
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await service.DeleteProduct(id);
                if (result >= 1)
                    return StatusCode(StatusCodes.Status201Created);
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

