using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Service
{
    public class OrderService : IOrderService
    {
        public ActionResult AddOrder( Order order )
        {
            throw new NotImplementedException();
        }

        public ActionResult DeleteOrder( int orderId )
        {
            throw new NotImplementedException();
        }

        public ActionResult EditOrder( Order order )
        {
            throw new NotImplementedException();
        }

        public ActionResult<Order> GetOrder( int orderId )
        {
            throw new NotImplementedException();
        }

        public ActionResult<List<Order>> GetOrders()
        {
            throw new NotImplementedException();
        }
    }
}
