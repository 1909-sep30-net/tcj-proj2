using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HelpByPros.DataAccess.Migrations
{
    public partial class improvementToData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Users_Id",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Professionals_Users_Id",
                table: "Professionals");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Professionals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Members",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Professionals_UserID",
                table: "Professionals",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_UserID",
                table: "Members",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Users_UserID",
                table: "Members",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professionals_Users_UserID",
                table: "Professionals",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Users_UserID",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Professionals_Users_UserID",
                table: "Professionals");

            migrationBuilder.DropIndex(
                name: "IX_Professionals_UserID",
                table: "Professionals");

            migrationBuilder.DropIndex(
                name: "IX_Members_UserID",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Professionals",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Members",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Users_Id",
                table: "Members",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professionals_Users_Id",
                table: "Professionals",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
