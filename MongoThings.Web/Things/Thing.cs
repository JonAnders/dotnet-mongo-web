using MongoDB.Bson;

namespace MongoThings.Web.Things
{
    public class Thing
    {
        public string Description { get; set; }
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}