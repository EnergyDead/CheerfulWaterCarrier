using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Controllers
{
    [ApiController]
    [Route( "api/" )]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _orderService;

        public OrderController( IOrder employeeService )
        {
            _orderService = employeeService;
        }

        [HttpGet( "orders" )]
        public ActionResult<List<Order>> GetOrders()
        {
            return _orderService.GetOrders();
        }

        [HttpGet( "order/{id}" )]
        public ActionResult<Order> GetOrder( int id )
        {
            return _orderService.GetOrder( id );
        }

        [HttpPost( "order/{id}/edit" )]
        public bool EditOrder( Order order )
        {
            return _orderService.EditOrder( order );
        }

        [HttpPost( "order/add" )]
        public bool AddOrder( Order order )
        {
            return _orderService.AddOrder( order );
        }

        [HttpPost( "order/{id}/delete" )]
        public bool DeleteOrder( int id )
        {
            return _orderService.DeleteOrder( id );
        }
    }
}
