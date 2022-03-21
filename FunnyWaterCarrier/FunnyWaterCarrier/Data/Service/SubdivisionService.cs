using FunnyWaterCarrier.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Service
{
    public class SubdivisionService : ISubdivision
    {
        public ActionResult AddSubdivision( Model.Subdivision subdivision )
        {
            throw new NotImplementedException();
        }

        public ActionResult DeleteSubdivision( int id )
        {
            throw new NotImplementedException();
        }

        public ActionResult EditSubdivision( Model.Subdivision subdivision )
        {
            throw new NotImplementedException();
        }

        public ActionResult<Model.Subdivision> GetSubdivision( int id )
        {
            throw new NotImplementedException();
        }

        public ActionResult<List<Model.Subdivision>> GetSubdivisions()
        {
            throw new NotImplementedException();
        }
    }
}
