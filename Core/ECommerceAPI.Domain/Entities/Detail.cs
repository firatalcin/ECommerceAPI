namespace ECommerceAPI.Domain.Entities
{
    public class Detail
    {
        public Detail()
        {
            
        }
        public Detail(string title, string description, int categoryId)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;
        }

        public required string Title { get; set; }
        public required string Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
