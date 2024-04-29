using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P01_CF.Migrations
{
    public partial class CreateCF101Db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PEMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PPostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PGender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Standards",
                columns: table => new
                {
                    StandardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standards", x => x.StandardId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SFName = table.Column<string>(type: "NVarchar(20)", nullable: false),
                    SLName = table.Column<string>(type: "NVarchar(30)", nullable: false),
                    SDoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StandardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Standards_StandardId",
                        column: x => x.StandardId,
                        principalTable: "Standards",
                        principalColumn: "StandardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StandardId",
                table: "Students",
                column: "StandardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Standards");
        }
    }
}
