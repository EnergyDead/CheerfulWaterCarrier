using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Interface
{
    public interface ISubdivision
    {
        public ActionResult<Subdivision> GetSubdivision( int id );
        public ActionResult<List<Subdivision>> GetSubdivisions();
        public ActionResult AddSubdivision( Subdivision subdivision );
        public ActionResult EditSubdivision( Subdivision subdivision );
        public ActionResult DeleteSubdivision( int id );
    }
}
