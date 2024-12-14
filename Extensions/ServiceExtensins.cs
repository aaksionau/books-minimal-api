using System.Reflection;
using BookStoreApi.Exceptions;
using BookStoreApi.Interfaces;
using BookStoreApi.Services;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BookStoreApi.Extensions;

public static class ServiceExtensions
{
    public static void AddApplicationServices(this IHostApplicationBuilder builder)
    {
        if(builder?.Configuration == null)
        {
            throw new ArgumentNullException(nameof(builder.Configuration));
        }

        builder.Services.AddDbContext<ApplicationContext>(options => {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            options.ConfigureWarnings(warnings =>     
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        });

        builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

        builder.Services.AddProblemDetails();

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddScoped<IBookService, BookService>();
    }
}

