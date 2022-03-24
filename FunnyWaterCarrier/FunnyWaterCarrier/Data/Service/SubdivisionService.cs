using EntityFramework;
using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;

namespace FunnyWaterCarrier.Data.Service
{
    public class SubdivisionService : ISubdivision
    {
        private List<string> _errors;
        public List<string> Errors()
        {
            return _errors;
        }

        public SubdivisionService()
        {
            _errors = new();
        }

        public void AddSubdivision( Subdivision subdivision )
        {
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    db.Subdivision.Add( subdivision );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
        }

        public void DeleteSubdivision( int id )
        {
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    var subdivision = db.Subdivision.FirstOrDefault( subdivision => subdivision.SubdivisionId == id );
                    db.Remove( subdivision );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
        }

        public void EditSubdivision( Subdivision subdivision )
        {
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    db.Subdivision.Update( subdivision );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
        }

        public Subdivision GetSubdivision( int id )
        {
            Subdivision subdivision = new();
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    subdivision = db.Subdivision.FirstOrDefault( subdivision => subdivision.SubdivisionId == id );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
            return subdivision;
        }

        public List<Subdivision> GetSubdivisions()
        {
            List<Subdivision> subdivisions = new();
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    subdivisions = db.Subdivision.ToList();
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
            return subdivisions;
        }
    }
}
