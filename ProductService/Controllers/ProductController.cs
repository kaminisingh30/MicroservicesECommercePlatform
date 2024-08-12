using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly List<Product> _products = new List<Product>
        { new Product{ Id= 1, Name= "Product1", Price = 100},
            new Product{ Id= 2, Name="Product2", Price= 200},
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_products);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) { 
        var product = _products.FirstOrDefault(x => x.Id == id);    
            if(product== null) return NotFound();
            return Ok(product);
        }
            
     }
}
