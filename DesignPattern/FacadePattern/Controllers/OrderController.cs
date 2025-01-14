using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FacadeDesignPatter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderFacade _orderFacade;

        public OrderController(OrderFacade orderFacade)
        {
            _orderFacade = orderFacade;
        }

        [HttpPost("place")]
        public IActionResult PlaceOrder([FromBody] OrderRequest request)
        {
            var result = _orderFacade.PlaceOrder(request.Username, request.Password, request.OrderId, request.Amount);
            return Ok(result);
        }
    }

    public class OrderRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
    }

}
