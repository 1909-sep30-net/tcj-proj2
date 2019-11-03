using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpByPros.DataAccess.Migrations
{
    public partial class addedQuestionBodytoQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuestionBody",
                table: "Questions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionBody",
                table: "Questions");
        }
    }
}
