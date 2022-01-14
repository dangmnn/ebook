namespace ebook.domain
{
    class Author
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }
    }
}