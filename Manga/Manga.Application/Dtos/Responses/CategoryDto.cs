namespace Categories
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Title { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
    }
}
