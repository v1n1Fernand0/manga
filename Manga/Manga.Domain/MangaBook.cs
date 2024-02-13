using Categories;

namespace MangaBooks
{
    public class MangaBook 
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public string? Author { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishedAt { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
