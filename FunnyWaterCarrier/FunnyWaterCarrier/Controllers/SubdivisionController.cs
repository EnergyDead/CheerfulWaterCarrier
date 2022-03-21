using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Controllers
{
    [ApiController]
    [Route( "api/" )]
    public class SubdivisionController
    {
        private readonly ISubdivision _subdivisionService;

        public SubdivisionController( ISubdivision subdivisionService )
        {
            _subdivisionService = subdivisionService;
        }

        [HttpGet( "subdivisions" )]
        public ActionResult<List<Subdivision>> GetSubdivision()
        {
            return _subdivisionService.GetSubdivisions();
        }

        [HttpGet( "subdivision/{id}" )]
        public ActionResult<Subdivision> GetSubdivision( int id )
        {
            return _subdivisionService.GetSubdivision( id );
        }

        [HttpGet( "subdivision/{id}/edit" )]
        public ActionResult<Subdivision> EditSubdivision( Subdivision subdivision )
        {
            return _subdivisionService.EditSubdivision( subdivision );
        }

        [HttpGet( "subdivision/{id}/delete" )]
        public ActionResult<Subdivision> DeleteEmployee( int id )
        {
            return _subdivisionService.DeleteSubdivision( id );
        }

        [HttpGet( "subdivision/add" )]
        public ActionResult<Subdivision> AddEmployee( Subdivision subdivision )
        {
            return _subdivisionService.AddSubdivision( subdivision );
        }
    }
}
