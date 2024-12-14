using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bookApi");

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "bookApi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalPages = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "bookApi",
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "Description", "Language", "Title", "TotalPages" },
                values: new object[,]
                {
                    { new Guid("017a7277-432e-408e-81b1-f5871fcf84d7"), "Sonja Bogisich", "repudiandae", "Qui accusantium ducimus dolor deserunt ut. Possimus beatae nulla voluptatibus numquam qui hic facilis quia dicta.", "veniam", "odio ducimus aut consequatur inventore", 0 },
                    { new Guid("20a59a8c-8ac0-4bdd-8c58-775679724a78"), "Sonja Bogisich", "modi", "Fuga laudantium aut. Accusantium aliquam iusto repudiandae perspiciatis excepturi ullam id consectetur. Sint optio accusamus dolorem aut provident et quibusdam. Eveniet sequi maiores repellat qui rerum dicta explicabo doloremque.", "nihil", "architecto at iure accusamus ipsa", 0 },
                    { new Guid("2216b452-eca8-4cfb-aa75-be45cba9b61e"), "Sonja Bogisich", "ad", "Blanditiis sed cum. Repellat dolorem vitae esse soluta occaecati maiores.", "nihil", "odio ut eveniet corrupti officiis", 0 },
                    { new Guid("31db715b-1a95-4604-a9f6-90f33c152309"), "Sonja Bogisich", "voluptatem", "Aspernatur quaerat et reprehenderit doloremque consequuntur dolores minima. Et voluptatem et fugiat dolorum nobis qui fuga unde rem. Quis commodi natus ea maiores. Qui sunt itaque in.", "dolor", "non quos temporibus velit temporibus", 0 },
                    { new Guid("35777745-8c78-4bc0-a610-68622c3d0945"), "Sonja Bogisich", "velit", "Ea iusto repellendus voluptas maiores dignissimos aspernatur necessitatibus rerum deserunt.", "excepturi", "qui unde quia ratione ea", 0 },
                    { new Guid("4ba85777-f4ad-4dff-87cb-2ed1a2fe646b"), "Sonja Bogisich", "quidem", "Excepturi numquam tempore earum sunt qui delectus. Magnam quia et sit.", "qui", "nisi eaque rerum perferendis aut", 0 },
                    { new Guid("51260475-0699-4a79-84a0-f6efe62e189c"), "Sonja Bogisich", "illo", "Perspiciatis sint harum sequi voluptatem sed accusamus cupiditate ut. Accusamus molestiae assumenda ut.", "officia", "vitae aspernatur quis ab est", 0 },
                    { new Guid("560419a7-1527-4d0e-90f0-ef9f010923e8"), "Sonja Bogisich", "soluta", "Accusamus aspernatur nesciunt commodi eos quo quas voluptatem aut. Illum quae delectus et est. Non commodi quas.", "eos", "sit quasi dolores pariatur veniam", 0 },
                    { new Guid("6569fc28-ac5d-4723-bd4f-ebf21b18c947"), "Sonja Bogisich", "quibusdam", "Adipisci enim quia veritatis debitis dicta reprehenderit exercitationem iure reiciendis.", "et", "maiores perspiciatis dolor rerum tempora", 0 },
                    { new Guid("7361ef1a-0a08-4e38-9583-ea2570da0823"), "Sonja Bogisich", "iure", "Voluptate quia nesciunt et illo numquam. Explicabo est omnis itaque eos ipsa corporis. Velit modi omnis fugit.", "saepe", "natus corporis et laborum sit", 0 },
                    { new Guid("83cca844-1262-4d48-819c-0c93fc533075"), "Sonja Bogisich", "laborum", "Sed nisi velit perferendis dolore. Esse dolor vitae quae quod fuga. Voluptatem vitae est qui nihil placeat omnis. Quia natus aliquid voluptatum.", "aut", "quis quia sunt placeat non", 0 },
                    { new Guid("874eeea7-e9a5-4823-92c0-ad46d0dd3e2a"), "Sonja Bogisich", "itaque", "Sed accusantium saepe qui consectetur. Suscipit dolor magnam ut cupiditate tenetur nemo.", "et", "fugiat aspernatur sed eveniet tempora", 0 },
                    { new Guid("8e1f99e0-de76-44d2-848b-b760a660a4c9"), "Sonja Bogisich", "molestiae", "At quos id omnis dolorem reiciendis voluptatibus. Quibusdam hic impedit consequatur qui consequatur et incidunt accusamus cumque.", "corrupti", "numquam quo vero magni non", 0 },
                    { new Guid("9af61d96-4438-42e0-80af-309e0ef7f781"), "Sonja Bogisich", "aliquid", "Consequuntur deleniti tempore ea. Facere similique aliquam mollitia et sit dolor sed autem et. Molestiae ut repellat voluptas.", "veniam", "maxime veritatis hic mollitia nobis", 0 },
                    { new Guid("a2d9f35d-c984-47ab-a2ba-46abb74935aa"), "Sonja Bogisich", "repudiandae", "Enim velit voluptatum et consequatur voluptatem hic. Beatae ut sed eveniet possimus.", "sit", "at ea tenetur ipsum eius", 0 },
                    { new Guid("a9d4512d-7b1e-4b65-80dd-75744b4faa71"), "Sonja Bogisich", "mollitia", "Praesentium esse reiciendis quia provident.", "non", "unde dolores blanditiis rerum aliquid", 0 },
                    { new Guid("af22d0ee-12e4-4cb9-b082-efb80be5aa1f"), "Sonja Bogisich", "quos", "Esse dolorem quibusdam perferendis laudantium. Deserunt ut optio ea aut. Aut odit et quae.", "labore", "reprehenderit quis pariatur dolor eius", 0 },
                    { new Guid("cd7e49e4-e677-4ed4-a2be-80b9bac28f3a"), "Sonja Bogisich", "commodi", "Modi id dolor quo. Est natus eius quis et similique vitae commodi nemo. Delectus consequatur reprehenderit ut ut.", "quo", "porro ex ullam sed in", 0 },
                    { new Guid("e08e1147-8008-44af-a543-b2acbf8c2d44"), "Sonja Bogisich", "aut", "Pariatur qui cumque autem dicta eligendi. Deleniti hic ullam porro neque deleniti doloribus quo aut dolor. Omnis possimus rerum esse. Sapiente magnam provident sint aut qui voluptatum sint reiciendis est.", "necessitatibus", "dolor accusamus officia eum voluptatem", 0 },
                    { new Guid("f760a87b-ee57-457a-9fca-ee62795a00f8"), "Sonja Bogisich", "omnis", "Est provident neque sunt autem in occaecati animi reiciendis perspiciatis. Ut corrupti molestiae expedita quo consequatur accusantium quisquam. Ut nam consectetur repellendus aut tempore.", "pariatur", "necessitatibus delectus doloribus tenetur saepe", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books",
                schema: "bookApi");
        }
    }
}
