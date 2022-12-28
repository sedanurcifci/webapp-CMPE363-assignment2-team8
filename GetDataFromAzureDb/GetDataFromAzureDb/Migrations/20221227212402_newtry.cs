using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetDataFromAzureDb.Migrations
{
    /// <inheritdoc />
    public partial class newtry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblEmployee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployee", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmployee");
        }
    }
}
