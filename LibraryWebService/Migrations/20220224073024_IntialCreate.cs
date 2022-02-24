using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryWebService.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id_author = table.Column<int>(type: "int", nullable: false),
                    AuthorName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id_author);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    id_genre = table.Column<int>(type: "int", nullable: false),
                    genreName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.id_genre);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id_group = table.Column<int>(type: "int", nullable: false),
                    groupName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id_group);
                });

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    Id_library = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LibraryName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.Id_library);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id_person = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Active = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id_person);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id_type = table.Column<int>(type: "int", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id_type);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id_student = table.Column<int>(type: "int", nullable: false),
                    Id_pers_StudFk = table.Column<int>(name: "Id_pers_Stud(Fk)", type: "int", nullable: false),
                    id_groupfk = table.Column<int>(name: "id_group(fk)", type: "int", nullable: false),
                    year = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id_student);
                    table.ForeignKey(
                        name: "FK_Students_Groups",
                        column: x => x.id_groupfk,
                        principalTable: "Groups",
                        principalColumn: "Id_group",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Persons",
                        column: x => x.Id_pers_StudFk,
                        principalTable: "Persons",
                        principalColumn: "Id_person",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id_worker = table.Column<int>(type: "int", nullable: false),
                    Id_pers_Workfk = table.Column<int>(name: "Id_pers_Work(fk)", type: "int", nullable: false),
                    Position = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id_worker);
                    table.ForeignKey(
                        name: "FK_Workers_Persons",
                        column: x => x.Id_pers_Workfk,
                        principalTable: "Persons",
                        principalColumn: "Id_person",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id_book = table.Column<int>(type: "int", nullable: false),
                    Id_authorFk = table.Column<int>(type: "int", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    amount = table.Column<int>(type: "int", nullable: true),
                    id_typeFk = table.Column<int>(type: "int", nullable: true),
                    imagePath = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    id_genreFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id_book);
                    table.ForeignKey(
                        name: "FK_Books_Authors",
                        column: x => x.Id_authorFk,
                        principalTable: "Authors",
                        principalColumn: "Id_author",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Genres",
                        column: x => x.id_genreFk,
                        principalTable: "Genres",
                        principalColumn: "id_genre",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Types",
                        column: x => x.id_typeFk,
                        principalTable: "Types",
                        principalColumn: "Id_type",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id_comment = table.Column<int>(type: "int", nullable: false),
                    id_studentCom = table.Column<int>(type: "int", nullable: true),
                    id_bookCom = table.Column<int>(type: "int", nullable: true),
                    Commnet = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id_comment);
                    table.ForeignKey(
                        name: "FK_Comments_Books",
                        column: x => x.id_bookCom,
                        principalTable: "Books",
                        principalColumn: "Id_book",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Comments",
                        column: x => x.id_studentCom,
                        principalTable: "Students",
                        principalColumn: "Id_student",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Libraries-Books",
                columns: table => new
                {
                    id_libraryFk = table.Column<int>(type: "int", nullable: true),
                    id_bookLbFk = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Libraries-Books_Books",
                        column: x => x.id_bookLbFk,
                        principalTable: "Books",
                        principalColumn: "Id_book",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libraries-Books_Libraries",
                        column: x => x.id_libraryFk,
                        principalTable: "Libraries",
                        principalColumn: "Id_library",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students-Books",
                columns: table => new
                {
                    id_bookS = table.Column<int>(type: "int", nullable: false),
                    id_studentS = table.Column<int>(type: "int", nullable: false),
                    dateofPicking = table.Column<DateTime>(type: "date", nullable: true),
                    dateofRetruning = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Students-Books_Books",
                        column: x => x.id_bookS,
                        principalTable: "Books",
                        principalColumn: "Id_book",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students-Books_Students",
                        column: x => x.id_studentS,
                        principalTable: "Students",
                        principalColumn: "Id_student",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_authorFk",
                table: "Books",
                column: "Id_authorFk");

            migrationBuilder.CreateIndex(
                name: "IX_Books_id_genreFk",
                table: "Books",
                column: "id_genreFk");

            migrationBuilder.CreateIndex(
                name: "IX_Books_id_typeFk",
                table: "Books",
                column: "id_typeFk");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_id_bookCom",
                table: "Comments",
                column: "id_bookCom");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_id_studentCom",
                table: "Comments",
                column: "id_studentCom");

            migrationBuilder.CreateIndex(
                name: "IX_Libraries-Books_id_bookLbFk",
                table: "Libraries-Books",
                column: "id_bookLbFk");

            migrationBuilder.CreateIndex(
                name: "IX_Libraries-Books_id_libraryFk",
                table: "Libraries-Books",
                column: "id_libraryFk");

            migrationBuilder.CreateIndex(
                name: "IX_Students_id_group(fk)",
                table: "Students",
                column: "id_group(fk)");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Id_pers_Stud(Fk)",
                table: "Students",
                column: "Id_pers_Stud(Fk)");

            migrationBuilder.CreateIndex(
                name: "IX_Students-Books_id_bookS",
                table: "Students-Books",
                column: "id_bookS");

            migrationBuilder.CreateIndex(
                name: "IX_Students-Books_id_studentS",
                table: "Students-Books",
                column: "id_studentS");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_Id_pers_Work(fk)",
                table: "Workers",
                column: "Id_pers_Work(fk)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Libraries-Books");

            migrationBuilder.DropTable(
                name: "Students-Books");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Libraries");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
