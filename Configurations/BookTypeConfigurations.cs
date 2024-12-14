using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BookTypeConfigurations : IEntityTypeConfiguration<BookModel>
{
    public void Configure(EntityTypeBuilder<BookModel> builder)
    {
        // Configure the table name
        builder.ToTable("Books");

        // Configure the primary key
        builder.HasKey(x => x.Id);

        // Configure properties
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Author).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
        builder.Property(x => x.Category).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Language).IsRequired().HasMaxLength(50);
        builder.Property(x => x.TotalPages).IsRequired();

        var books = new List<BookModel>();
        var faker = new Faker("en");
        Enumerable.Range(0,20).ToList().ForEach(index => {
            var book = new BookModel()
            {
                Id = Guid.NewGuid(),
                Title = string.Join(" ", faker.Lorem.Words(5)),
                Author = faker.Person.FullName,
                Description = faker.Lorem.Paragraph(1),
                Category = faker.Lorem.Word(),
                Language = faker.Lorem.Word()
            };
            books.Add(book);
        });

        builder.HasData(books);
    }
}