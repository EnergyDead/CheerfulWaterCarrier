using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Interface
{
    public interface ISubdivision
    {
        public ActionResult<Subdivision> GetSubdivision( int id );
        public ActionResult<List<Subdivision>> GetSubdivisions();
        public bool AddSubdivision( Subdivision subdivision );
        public bool EditSubdivision( Subdivision subdivision );
        public bool DeleteSubdivision( int id );
    }
}
