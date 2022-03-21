using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using FunnyWaterCarrier.Data.Stub;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Service
{
    public class OrderService : IOrder
    {
        readonly OrderStub _orderStub;
        public OrderService()
        {
            _orderStub = new();
        }

        public ActionResult AddOrder( Order order )
        {
            _orderStub.Orders.Add( order );

            return null;
        }

        public ActionResult DeleteOrder( int orderId )
        {
            var order = _orderStub.Orders.FirstOrDefault( order => order.Id == orderId );
            _orderStub.Orders.Remove( order );

            return null;
        }

        public ActionResult EditOrder( Order newOrder )
        {
            _orderStub.Orders.Where( order => order.Id == newOrder.Id ).Select( order => order = newOrder );

            return null;
        }

        public Order GetOrder( int orderId )
        {
            return _orderStub.Orders.First( ordr => ordr.Id == orderId );
        }

        public List<Order> GetOrders()
        {
            return _orderStub.Orders;
        }
    }
}
