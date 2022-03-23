using FunnyWaterCarrier.Data.Model;

namespace FunnyWaterCarrier.Data.Stub
{
    public class OrderStub
    {
        private static List<Order> _orders;
        public List<Order> Orders { get => _orders; set => _orders = value; }

        public OrderStub()
        {
            _orders = new List<Order>()
            {
                new Order() { OrderId = 1, Name = "Заказ Первый", EmployeeId = 1 },
                new Order() { OrderId = 2, Name = "Заказ Второй", EmployeeId = 1 },
                new Order() { OrderId = 3, Name = "Заказ Теретий", EmployeeId = 0 },
                new Order() { OrderId = 4, Name = "Заказ Четверый", EmployeeId = 1 },
                new Order() { OrderId = 5, Name = "Заказ Пятый", EmployeeId = 0 },
                new Order() { OrderId = 6, Name = "Заказ Шестой", EmployeeId = 2 },
                new Order() { OrderId = 7, Name = "Заказ Последний", EmployeeId = 2 }
            };
        }
    }
}