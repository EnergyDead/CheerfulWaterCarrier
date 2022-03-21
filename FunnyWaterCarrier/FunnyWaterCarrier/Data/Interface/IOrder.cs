using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Interface
{
    public interface IOrder
    {
        public List<Order> GetOrders();
        public Order GetOrder( int orderId );
        public bool AddOrder( Order order );
        public bool EditOrder( Order order );
        public bool DeleteOrder( int orderId );
    }
}
