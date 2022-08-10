namespace SuggestionAppLibrary.Models
{
    public class CategoryModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }
        public String CategoryName { get; set; }
        public String CategoryDescription { get; set; }
    }
}
