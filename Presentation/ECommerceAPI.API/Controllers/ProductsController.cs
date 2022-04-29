
using System.Net;
using ECommerceAPI.Application.Repositories.Product;
using ECommerceAPI.Application.ViewModels.Products;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _context;

        public ProductsController(IProductWriteRepository context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Add(VM_Create_Product model)
        {
            Product product = new Product
            {
                Name = model.Name,
                Stock = model.Stock,
                Price = model.Price
            };

            await _context.InsertAsync(product);
            await _context.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}
