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
                new Order() { Id = 1, Name = "Заказ Первый" },
                new Order() { Id = 2, Name = "Заказ Второй" },
                new Order() { Id = 3, Name = "Заказ Теретий" },
                new Order() { Id = 4, Name = "Заказ Четверый" },
                new Order() { Id = 5, Name = "Заказ Пятый" },
                new Order() { Id = 6, Name = "Заказ Шестой" },
                new Order() { Id = 7, Name = "Заказ Последний" }
            };
        }
    }
}
