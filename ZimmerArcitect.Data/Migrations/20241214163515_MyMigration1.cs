using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZimmerArcitect.Data.Migrations
{
    public partial class MyMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataZimmers_DataCleaners_CleanerId",
                table: "DataZimmers");

            migrationBuilder.RenameColumn(
                name: "CleanerId",
                table: "DataZimmers",
                newName: "cleanerId");

            migrationBuilder.RenameIndex(
                name: "IX_DataZimmers_CleanerId",
                table: "DataZimmers",
                newName: "IX_DataZimmers_cleanerId");

            migrationBuilder.AlterColumn<int>(
                name: "cleanerId",
                table: "DataZimmers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DataZimmers_DataCleaners_cleanerId",
                table: "DataZimmers",
                column: "cleanerId",
                principalTable: "DataCleaners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataZimmers_DataCleaners_cleanerId",
                table: "DataZimmers");

            migrationBuilder.RenameColumn(
                name: "cleanerId",
                table: "DataZimmers",
                newName: "CleanerId");

            migrationBuilder.RenameIndex(
                name: "IX_DataZimmers_cleanerId",
                table: "DataZimmers",
                newName: "IX_DataZimmers_CleanerId");

            migrationBuilder.AlterColumn<int>(
                name: "CleanerId",
                table: "DataZimmers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DataZimmers_DataCleaners_CleanerId",
                table: "DataZimmers",
                column: "CleanerId",
                principalTable: "DataCleaners",
                principalColumn: "Id");

        }
    }
}
