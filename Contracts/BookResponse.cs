public record BookResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Language { get; set; }
    public int TotalPages { get; set; }

    public static BookResponse MapBook(BookModel existingBook)
    {
        return new BookResponse()
        {
            Id = existingBook.Id,
            Title = existingBook.Title,
            Author = existingBook.Author,
            Description = existingBook.Description,
            Category = existingBook.Category,
            Language = existingBook.Language,
            TotalPages = existingBook.TotalPages
        };
    }
}