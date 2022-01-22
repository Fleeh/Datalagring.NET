using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErrandHandler.Migrations
{
    public partial class Inits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Errands_Admins_AdminId",
                table: "Errands");

            migrationBuilder.DropColumn(
                name: "RoleId2",
                table: "Errands");

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Errands",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Errands_Admins_AdminId",
                table: "Errands",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Errands_Admins_AdminId",
                table: "Errands");

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Errands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RoleId2",
                table: "Errands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Errands_Admins_AdminId",
                table: "Errands",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");
        }
    }
}
