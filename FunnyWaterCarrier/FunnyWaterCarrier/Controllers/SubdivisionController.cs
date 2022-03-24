

using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        public List<Subdivision> GetSubdivision()
        {
            return _subdivisionService.GetSubdivisions();
        }

        [HttpGet( "subdivision/{id}" )]
        public Subdivision GetSubdivision( int id )
        {
            return _subdivisionService.GetSubdivision( id );
        }

        [HttpPost( "subdivision/{id}/edit" )]
        public HttpResponseMessage EditSubdivision( Subdivision subdivision )
        {
            _subdivisionService.EditSubdivision( subdivision );

            return new HttpResponseMessage( GetCode( _subdivisionService.Errors().Count ) );
        }

        [HttpPost( "subdivision/{id}/delete" )]
        public HttpResponseMessage DeleteEmployee( int id )
        {
            _subdivisionService.DeleteSubdivision( id );

            return new HttpResponseMessage( GetCode( _subdivisionService.Errors().Count ) );
        }

        [HttpPost( "subdivision/add" )]
        public HttpResponseMessage AddEmployee( Subdivision subdivision )
        {
            _subdivisionService.AddSubdivision( subdivision );

            return new HttpResponseMessage( GetCode( _subdivisionService.Errors().Count ) );
        }

        private static HttpStatusCode GetCode( int errorCount )
        {
            if ( errorCount > 0 )
            {
                return HttpStatusCode.BadRequest;
            }
            return HttpStatusCode.OK;
        }
    }
}
