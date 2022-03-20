using FunnyWaterCarrier.Data.Model;

namespace FunnyWaterCarrier.Data.Stub
{
    public class OrderStub
    {
        private List<Order> _orders;
        public List<Order> Orders { get => _orders; set => _orders = value; }

        public OrderStub()
        {
            _orders = new List<Order>()
            {
                new Order() { Id = 1, Name = "Заказ Первый", ExecutorId = 1 },
                new Order() { Id = 2, Name = "Заказ Второй", ExecutorId = 1 },
                new Order() { Id = 3, Name = "Заказ Теретий", ExecutorId = 0 },
                new Order() { Id = 4, Name = "Заказ Четверый", ExecutorId = 1 },
                new Order() { Id = 5, Name = "Заказ Пятый", ExecutorId = 0 },
                new Order() { Id = 6, Name = "Заказ Шестой", ExecutorId = 2 },
                new Order() { Id = 7, Name = "Заказ Последний", ExecutorId = 2 }
            };
        }
    }
}
