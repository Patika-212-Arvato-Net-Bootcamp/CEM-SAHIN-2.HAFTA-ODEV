using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addmigrationmig_new_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Bootcamps_BootcampId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BootcampId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_BootcampId",
                table: "Users",
                column: "BootcampId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Bootcamps_BootcampId",
                table: "Users",
                column: "BootcampId",
                principalTable: "Bootcamps",
                principalColumn: "BootcampId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
