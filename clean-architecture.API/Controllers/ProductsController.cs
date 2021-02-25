using clean_architecture.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace clean_architecture.API.Controllers
{

    [Route("api/[controller")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet("{id")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);

            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
        
    }
}