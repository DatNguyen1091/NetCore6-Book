using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore6_Book.Models;
using NetCore6_Book.Reponsitory;

namespace NetCore6_Book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepo;

        public MyProductsController(IProductRepository repo)
        {
            _productRepo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            try
            {
                return Ok(await _productRepo.GetAllProductAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productRepo.GetProductAsync(id);
            return product == null ? NotFound() : Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewProduct(ProductModel model)
        {
            try
            {
                var newProductId = await _productRepo.AddProductAsync(model);
                var product = await _productRepo.GetProductAsync(newProductId);
                return product == null ? NotFound() : Ok(product);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductById(int id, [FromBody] ProductModel model)
        {
            await _productRepo.UpdateProductAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductById([FromRoute] int id)
        {
            await _productRepo.DeleteProductAsync(id);
            return Ok();
        }
    }
}
