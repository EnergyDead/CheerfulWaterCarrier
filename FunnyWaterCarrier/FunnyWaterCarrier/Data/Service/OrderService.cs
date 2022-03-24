using EntityFramework;
using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;

namespace FunnyWaterCarrier.Data.Service
{
    public class OrderService : IOrder
    {
        private List<string> _errors;
        public List<string> Errors()
        {
            return _errors;
        }

        public OrderService()
        {
            _errors = new();
        }

        public void AddOrder( Order order )
        {
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    db.Order.Add( order );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
        }

        public void DeleteOrder( int orderId )
        {
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    var order = db.Order.FirstOrDefault( order => order.OrderId == orderId );
                    db.Remove( order );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
        }

        public void EditOrder( Order newOrder )
        {
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    db.Order.Update( newOrder );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
        }

        public Order GetOrder( int orderId )
        {
            Order order = new();
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    order = db.Order.FirstOrDefault( order => order.OrderId == orderId );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
            return order;
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new();
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    orders = db.Order.ToList();
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
            return orders;
        }
    }
}
