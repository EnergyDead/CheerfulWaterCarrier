using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Interface
{
    public interface ITag
    {
        // todo: вернуть список тегов по List<id>
        public ActionResult<List<Tag>> GetTags();
        public ActionResult<Tag> GetTag( int tagId );
        public ActionResult<Tag> AddTag( Tag tag );
        public ActionResult<Tag> DeleteTag( int tagId );
    }
}
