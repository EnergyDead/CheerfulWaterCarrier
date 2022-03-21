namespace FunnyWaterCarrier.Data.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeId { get; set; }

        private List<Tag> _tags = new();

        public List<Tag> GetTags()
        {
            return _tags;
        }

        public void AddTags( Tag value )
        {
            _tags.Add( value );
        }
    }
}
