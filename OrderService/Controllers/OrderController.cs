using Microsoft.AspNetCore.Mvc;
using OrderService.Models;

namespace OrderService.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly List<Order> _orders = new List<Order>
    {
        new Order { Id = 1, ProductId = 1, Quantity = 2, OrderDate = DateTime.UtcNow },
        new Order { Id = 2, ProductId = 2, Quantity = 1, OrderDate = DateTime.UtcNow }
    };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orders);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var order = _orders.FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();
            return Ok(order);
        }
    }
}
