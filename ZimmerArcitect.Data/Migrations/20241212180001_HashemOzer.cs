using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZimmerArcitect.Data.Migrations
{
    public partial class HashemOzer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cleaner_id",
                table: "DataZimmers");

            migrationBuilder.RenameColumn(
                name: "Owner_id",
                table: "DataZimmers",
                newName: "ownerId");

            migrationBuilder.AddColumn<int>(
                name: "CleanerId",
                table: "DataZimmers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataZimmers_CleanerId",
                table: "DataZimmers",
                column: "CleanerId");

            migrationBuilder.CreateIndex(
                name: "IX_DataZimmers_ownerId",
                table: "DataZimmers",
                column: "ownerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataZimmers_DataCleaners_CleanerId",
                table: "DataZimmers",
                column: "CleanerId",
                principalTable: "DataCleaners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DataZimmers_DataOwners_ownerId",
                table: "DataZimmers",
                column: "ownerId",
                principalTable: "DataOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataZimmers_DataCleaners_CleanerId",
                table: "DataZimmers");

            migrationBuilder.DropForeignKey(
                name: "FK_DataZimmers_DataOwners_ownerId",
                table: "DataZimmers");

            migrationBuilder.DropIndex(
                name: "IX_DataZimmers_CleanerId",
                table: "DataZimmers");

            migrationBuilder.DropIndex(
                name: "IX_DataZimmers_ownerId",
                table: "DataZimmers");

            migrationBuilder.DropColumn(
                name: "CleanerId",
                table: "DataZimmers");

            migrationBuilder.RenameColumn(
                name: "ownerId",
                table: "DataZimmers",
                newName: "Owner_id");

            migrationBuilder.AddColumn<int>(
                name: "Cleaner_id",
                table: "DataZimmers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
