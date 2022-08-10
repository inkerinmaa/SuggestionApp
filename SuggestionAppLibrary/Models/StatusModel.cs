namespace SuggestionAppLibrary.Models
{
    public class StatusModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }
        public String StatusName { get; set; }
        public String StatusDescription { get; set; }
    }
}
