using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Interface
{
    public interface IOrderService
    {
        public ActionResult<List<Order>> GetOrders();
        public ActionResult<Order> GetOrder( int orderId );
        public ActionResult AddOrder( Order order );
        public ActionResult EditOrder( Order order );
        public ActionResult DeleteOrder( int orderId );
    }
}
