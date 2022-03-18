using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Service
{
    public class TagService : ITagService
    {
        public ActionResult<Tag> AddTag( Tag tag )
        {
            throw new NotImplementedException();
        }

        public ActionResult<Tag> DeleteTag( int tagId )
        {
            throw new NotImplementedException();
        }

        public ActionResult<Tag> GetTag( int tagId )
        {
            throw new NotImplementedException();
        }

        public ActionResult<List<Tag>> GetTags()
        {
            throw new NotImplementedException();
        }
    }
}
