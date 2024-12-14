using BookStoreApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Services;

public class BookService : IBookService
{
    private readonly ApplicationContext context;
    private readonly ILogger<ApplicationContext> logger;

    public BookService(
        ApplicationContext context,
        ILogger<ApplicationContext> logger)
    {
        this.context = context;
        this.logger = logger;
    }
    public async Task<BookResponse> AddBookAsync(CreateBookRequest createBookRequest)
    {
        var book = new BookModel
        {
            Title = createBookRequest.Title,
            Author = createBookRequest.Author,
            Description = createBookRequest.Description,
            Category = createBookRequest.Category,
            Language = createBookRequest.Language,
            TotalPages = createBookRequest.TotalPages
        };

        // Add the book to the database
        context.Books.Add(book);
        await context.SaveChangesAsync();
        logger.LogInformation("Book added successfully.");

        // Return the details of the created book
        return BookResponse.MapBook(book);
    }

    public async Task<bool> DeleteBookAsync(Guid id)
    {
        var book = await context.Books.FindAsync(id);
        if (book == null)
        {
            logger.LogWarning($"Book with ID {id} not found.");
            return false;
        }

        // Remove the book from the database
        context.Books.Remove(book);
        await context.SaveChangesAsync();
        logger.LogInformation($"Book with ID {id} deleted successfully.");
        return true;
    }

    public async Task<BookResponse> GetBookByIdAsync(Guid id)
    {
        // Find the book by its ID
        var book = await context.Books.FindAsync(id);
        if (book == null)
        {
            logger.LogWarning($"Book with ID {id} not found.");
            return null;
        }

        // Return the details of the book
        return BookResponse.MapBook(book);
    }

    public async Task<IEnumerable<BookResponse>> GetBooksAsync()
    {
        var books = await context.Books.ToListAsync();

        // Return the details of all books
        return books.Select(book => BookResponse.MapBook(book));
    }

    public async Task<BookResponse> UpdateBookAsync(Guid id, UpdateBookRequest book)
    {
        var existingBook = await context.Books.FindAsync(id);
        if (existingBook == null)
        {
            logger.LogWarning($"Book with ID {id} not found.");
            return null;
        }

        // Update the book details
        existingBook.Title = book.Title;
        existingBook.Author = book.Author;
        existingBook.Description = book.Description;
        existingBook.Category = book.Category;
        existingBook.Language = book.Language;
        existingBook.TotalPages = book.TotalPages;

        // Save the changes to the database
        await context.SaveChangesAsync();
        logger.LogInformation("Book updated successfully.");

        // Return the details of the updated book
        return BookResponse.MapBook(existingBook);
    }
}