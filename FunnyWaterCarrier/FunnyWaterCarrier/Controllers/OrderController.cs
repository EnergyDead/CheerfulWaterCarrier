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

        [HttpGet( "order/{id}/edit" )]
        public ActionResult<Order> EditOrder( Order order )
        {
            return _orderService.EditOrder( order );
        }

        [HttpGet( "order/add" )]
        public ActionResult<Order> AddOrder( Order order )
        {
            return _orderService.AddOrder( order );
        }

        [HttpGet( "order/{id}/delete" )]
        public ActionResult<Order> DeleteOrder( int orderId )
        {
            return _orderService.DeleteOrder( orderId );
        }
    }
}
