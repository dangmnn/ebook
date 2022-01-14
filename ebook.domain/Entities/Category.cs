namespace ebook.domain
{
    class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }
}