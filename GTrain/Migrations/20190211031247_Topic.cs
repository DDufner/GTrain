using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GTrain.Migrations
{
    public partial class Topic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TopicCategories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false),
                    TopicID = table.Column<int>(nullable: false),
                    CategoryTopicID = table.Column<int>(nullable: true),
                    CategoryID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicCategories", x => new { x.TopicID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_TopicCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicCategories_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicCategories_TopicCategories_CategoryTopicID_CategoryID1",
                        columns: x => new { x.CategoryTopicID, x.CategoryID1 },
                        principalTable: "TopicCategories",
                        principalColumns: new[] { "TopicID", "CategoryID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TopicCategories_CategoryID",
                table: "TopicCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_TopicCategories_CategoryTopicID_CategoryID1",
                table: "TopicCategories",
                columns: new[] { "CategoryTopicID", "CategoryID1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopicCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
