using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartman.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Departid",
                table: "Personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Departmanlarid",
                table: "Departmanlars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_Departid",
                table: "Personels",
                column: "Departid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmanlars_Departid",
                table: "Personels",
                column: "Departid",
                principalTable: "Departmanlars",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departmanlars_Departmanlars_Departmanlarid",
                table: "Departmanlars");

            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmanlars_Departid",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_Departid",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Departmanlars_Departmanlarid",
                table: "Departmanlars");

            migrationBuilder.DropColumn(
                name: "Departid",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "Departmanlarid",
                table: "Departmanlars");
        }
    }
}
