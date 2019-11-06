using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HelpByPros.DataAccess.Migrations
{
    public partial class improvementToData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Categorys_CategoryID",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CategoryID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Professionals_Id",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Questions",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Questions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Category = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryID",
                table: "Questions",
                column: "CategoryID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professionals_Id",
                table: "Professionals",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_Id",
                table: "Categorys",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Categorys_CategoryID",
                table: "Questions",
                column: "CategoryID",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
