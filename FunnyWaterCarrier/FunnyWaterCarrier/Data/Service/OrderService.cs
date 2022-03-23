using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using FunnyWaterCarrier.Data.Stub;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Service
{
    public class OrderService : IOrder
    {
        readonly OrderStub _orderStub;
        readonly string _connectionString;
        public OrderService(string connectionString )
        {
            _orderStub = new();
            _connectionString = connectionString;
        }

        public bool AddOrder( Order order )
        {
            int index = _orderStub.Orders.Select( order => order.OrderId ).Max();
            order.OrderId = index + 1;
            _orderStub.Orders.Add( order );

            return true;
        }

        public bool DeleteOrder( int orderId )
        {
            var order = _orderStub.Orders.FirstOrDefault( order => order.OrderId == orderId );
            _orderStub.Orders.Remove( order );

            return true;
        }

        public bool EditOrder( Order newOrder )
        {
            _orderStub.Orders.Where( order => order.OrderId == newOrder.OrderId ).Select( order => order = newOrder );

            return true;
        }

        public Order GetOrder( int orderId )
        {
            return _orderStub.Orders.First( ordr => ordr.OrderId == orderId );
        }

        public List<Order> GetOrders()
        {
            return _orderStub.Orders;
        }
    }
}
