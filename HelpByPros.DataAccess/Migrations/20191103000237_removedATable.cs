using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HelpByPros.DataAccess.Migrations
{
    public partial class removedATable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PointAvailable = table.Column<int>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Category = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(maxLength: 64, nullable: false),
                    LastName = table.Column<string>(maxLength: 64, nullable: false),
                    Profile_Pic = table.Column<byte[]>(nullable: true),
                    Phone = table.Column<string>(maxLength: 64, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Username = table.Column<string>(maxLength: 64, nullable: false),
                    Password = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsersID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admin_Users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    AccountInfoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_AccountInfos_AccountInfoID",
                        column: x => x.AccountInfoID,
                        principalTable: "AccountInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Members_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professionals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    AccountInfoID = table.Column<int>(nullable: false),
                    Expertise = table.Column<string>(nullable: false),
                    YearsOfExp = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professionals_AccountInfos_AccountInfoID",
                        column: x => x.AccountInfoID,
                        principalTable: "AccountInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Professionals_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    UserQuestion = table.Column<string>(maxLength: 126, nullable: false),
                    UsersID = table.Column<int>(nullable: false),
                    Answered = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Categorys_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QuestionID = table.Column<int>(nullable: false),
                    UpVote = table.Column<int>(maxLength: 4, nullable: false),
                    DownVote = table.Column<int>(maxLength: 4, nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    Answer = table.Column<string>(nullable: true),
                    Sources = table.Column<string>(maxLength: 64, nullable: false),
                    Best = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountInfos_Id",
                table: "AccountInfos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admin_Id",
                table: "Admin",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UsersID",
                table: "Admin",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_Id",
                table: "Answers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionID",
                table: "Answers",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserID",
                table: "Answers",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_Id",
                table: "Categorys",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Members_AccountInfoID",
                table: "Members",
                column: "AccountInfoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Members_Id",
                table: "Members",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professionals_AccountInfoID",
                table: "Professionals",
                column: "AccountInfoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professionals_Id",
                table: "Professionals",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryID",
                table: "Questions",
                column: "CategoryID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_Id",
                table: "Questions",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_UsersID",
                table: "Questions",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id",
                table: "Users",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Phone",
                table: "Users",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Professionals");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "AccountInfos");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
