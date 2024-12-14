namespace BookStoreApi.Exceptions;

public class NoBookFoundException : Exception
{
    public NoBookFoundException(string id) : base($"Book with id: {id} was not found")
    {

    }
}