using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        public List<Order> GetOrders()
        {
            return _orderService.GetOrders();
        }

        [HttpGet( "order/{id}" )]
        public Order GetOrder( int id )
        {
            return _orderService.GetOrder( id );
        }

        [HttpPost( "order/{id}/edit" )]
        public HttpResponseMessage EditOrder( Order order )
        {
            _orderService.EditOrder( order );

            return new HttpResponseMessage( GetCode( _orderService.Errors().Count ) );
        }

        [HttpPost( "order/add" )]
        public HttpResponseMessage AddOrder( Order order )
        {
            _orderService.AddOrder( order );

            return new HttpResponseMessage( GetCode( _orderService.Errors().Count ) );
        }

        [HttpPost( "order/{id}/delete" )]
        public HttpResponseMessage DeleteOrder( int id )
        {
            _orderService.DeleteOrder( id );

            return new HttpResponseMessage( GetCode( _orderService.Errors().Count ) );
        }

        private static HttpStatusCode GetCode( int errorCount )
        {
            if ( errorCount > 0 )
            {
                return HttpStatusCode.BadRequest;
            }
            return  HttpStatusCode.OK;
        }
    }
}
