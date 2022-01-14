namespace ebook.domain
{
    /*
    Book(Id, name, categoryId, authorId)
    */
    class Book
    {
        public int Id { get; set; }//PK

        public int CategoryId { get; set; }//FK

        public int AuthorId { get; set; }//FK

        public string Name { get; set; } = null!;

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }
}