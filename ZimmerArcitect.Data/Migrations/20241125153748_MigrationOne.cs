using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZimmerArcitect.Data.Migrations
{
    public partial class MigrationOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataCleaners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank_account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_registration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total_for_an_hour_of_work = table.Column<int>(type: "int", nullable: false),
                    Total_salary = table.Column<int>(type: "int", nullable: false),
                    Total_working_hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCleaners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Zimmer_id = table.Column<int>(type: "int", nullable: false),
                    Starting_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Num_of_nights = table.Column<int>(type: "int", nullable: false),
                    Total_sum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataOwners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank_account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_registration = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank_account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_registration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Max_amount_per_night = table.Column<int>(type: "int", nullable: false),
                    Num_of_persons = table.Column<int>(type: "int", nullable: false),
                    Num_of_orders = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataZimmers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Owner_id = table.Column<int>(type: "int", nullable: false),
                    Cleaner_id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_of_rooms = table.Column<int>(type: "int", nullable: false),
                    Num_of_beds = table.Column<int>(type: "int", nullable: false),
                    Yard_and_pool = table.Column<bool>(type: "bit", nullable: false),
                    Total_per_night = table.Column<int>(type: "int", nullable: false),
                    Num_of_nights_rented = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataZimmers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataCleaners");

            migrationBuilder.DropTable(
                name: "DataOrders");

            migrationBuilder.DropTable(
                name: "DataOwners");

            migrationBuilder.DropTable(
                name: "DataUser");

            migrationBuilder.DropTable(
                name: "DataZimmers");
        }
    }
}
