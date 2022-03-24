using FunnyWaterCarrier.Data.Model;

namespace FunnyWaterCarrier.Data.Interface
{
    public interface ISubdivision
    {
        public Subdivision GetSubdivision( int id );
        public List<Subdivision> GetSubdivisions();
        public void AddSubdivision( Subdivision subdivision );
        public void EditSubdivision( Subdivision subdivision );
        public void DeleteSubdivision( int id );
        public List<string> Errors();
    }
}
