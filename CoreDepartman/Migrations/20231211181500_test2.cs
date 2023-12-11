using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartman.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departmanlars_Departmanlars_Departmanlarid",
                table: "Departmanlars");

            migrationBuilder.DropIndex(
                name: "IX_Departmanlars_Departmanlarid",
                table: "Departmanlars");

            migrationBuilder.DropColumn(
                name: "Departmanlarid",
                table: "Departmanlars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Departmanlarid",
                table: "Departmanlars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departmanlars_Departmanlarid",
                table: "Departmanlars",
                column: "Departmanlarid");

            migrationBuilder.AddForeignKey(
                name: "FK_Departmanlars_Departmanlars_Departmanlarid",
                table: "Departmanlars",
                column: "Departmanlarid",
                principalTable: "Departmanlars",
                principalColumn: "id");
        }
    }
}
