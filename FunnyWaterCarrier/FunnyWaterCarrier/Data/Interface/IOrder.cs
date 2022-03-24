using FunnyWaterCarrier.Data.Model;

namespace FunnyWaterCarrier.Data.Interface
{
    public interface IOrder
    {
        public List<Order> GetOrders();
        public Order GetOrder( int orderId );
        public void AddOrder( Order order );
        public void EditOrder( Order order );
        public void DeleteOrder( int orderId );
        public List<string> Errors();
    }
}
