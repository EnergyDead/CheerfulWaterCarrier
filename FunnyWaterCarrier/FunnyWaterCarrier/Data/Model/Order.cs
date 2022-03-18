namespace FunnyWaterCarrier.Data.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExecutorId { get; set; }

        private List<Tag> _tags;

        public List<Tag> GetTags()
        {
            return _tags;
        }

        public void AddTags( Tag value )
        {
            if ( _tags == null )
            {
                _tags = new List<Tag>();
            }
            _tags.Add( value );
        }
    }
}
