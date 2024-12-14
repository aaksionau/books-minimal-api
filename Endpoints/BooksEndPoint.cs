using BookStoreApi.Interfaces;

public static class BooksEndpoints
{
    public static IEndpointRouteBuilder MapBooksEndPoint(this IEndpointRouteBuilder builder)
    {

        builder.MapPost("/books", async (CreateBookRequest createBookRequest, IBookService bookService) =>
        {
            var result = await bookService.AddBookAsync(createBookRequest);
            return Results.Created($"/books/{result.Id}", result);
        });

    
        builder.MapGet("/books", async (IBookService bookService) =>
        {
            var result = await bookService.GetBooksAsync();
            return Results.Ok(result);
        });


        builder.MapGet("/books/{id:guid}", async (Guid id, IBookService bookService) =>
        {
            var result = await bookService.GetBookByIdAsync(id);
            return result != null ? Results.Ok(result) : Results.NotFound();
        });

        builder.MapPut("/books/{id:guid}", async (Guid id, UpdateBookRequest updateBookRequest, IBookService bookService) =>
        {
            var result = await bookService.UpdateBookAsync(id, updateBookRequest);
            return result != null ? Results.Ok(result) : Results.NotFound();
        });

        builder.MapDelete("/books/{id:guid}", async (Guid id, IBookService bookService) =>
        {
            var result = await bookService.DeleteBookAsync(id);
            return result ? Results.NoContent() : Results.NotFound();
        });
        return builder;
    }
}