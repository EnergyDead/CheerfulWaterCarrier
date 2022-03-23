using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Stub;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Service
{
    public class SubdivisionService : ISubdivision
    {
        readonly SubdivisionStub _subdivisionStub;
        public SubdivisionService()
        {
            _subdivisionStub = new();
        }

        public bool AddSubdivision( Model.Subdivision subdivision )
        {
            int index = _subdivisionStub.Subdivisions.Select( subdivision => subdivision.Id ).Max();
            subdivision.Id = index + 1;
            _subdivisionStub.Subdivisions.Add( subdivision );

            return true;
        }

        public bool DeleteSubdivision( int id )
        {
            var subdivision = _subdivisionStub.Subdivisions.FirstOrDefault( subdivision => subdivision.Id == id );
            _subdivisionStub.Subdivisions.Remove( subdivision );

            return true;
        }

        public bool EditSubdivision( Model.Subdivision subdivision )
        {
            return true;
        }

        public ActionResult<Model.Subdivision> GetSubdivision( int id )
        {
            return _subdivisionStub.Subdivisions.First( ordr => ordr.Id == id );
        }

        public ActionResult<List<Model.Subdivision>> GetSubdivisions()
        {
            return _subdivisionStub.Subdivisions;
        }
    }
}
