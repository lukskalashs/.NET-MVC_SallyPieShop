using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SallyPieShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pies",
                table: "Pies");

            migrationBuilder.RenameTable(
                name: "Pies",
                newName: "Pie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pie",
                table: "Pie",
                column: "PieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pie",
                table: "Pie");

            migrationBuilder.RenameTable(
                name: "Pie",
                newName: "Pies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pies",
                table: "Pies",
                column: "PieId");
        }
    }
}
