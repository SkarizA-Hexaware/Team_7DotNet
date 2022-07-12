using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_7WebAPI.Migrations
{
    public partial class initTeam7_webApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "manager_Details_Section_Dbs",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manager_Details_Section_Dbs", x => x.Employee_ID);
                });

            migrationBuilder.CreateTable(
                name: "my_Details_Section_Dbs",
                columns: table => new
                {
                    Employee_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Full_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile_Number = table.Column<long>(type: "bigint", nullable: false),
                    Date_Joined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Available_Leave_Balance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_my_Details_Section_Dbs", x => x.Employee_Id);
                });

            migrationBuilder.CreateTable(
                name: "My_Leave_Application_Section_Dbs",
                columns: table => new
                {
                    Leave_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number_of_Days = table.Column<int>(type: "int", nullable: false),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leave_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Applied_ON = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Manager_comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_My_Leave_Application_Section_Dbs", x => x.Leave_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "manager_Details_Section_Dbs");

            migrationBuilder.DropTable(
                name: "my_Details_Section_Dbs");

            migrationBuilder.DropTable(
                name: "My_Leave_Application_Section_Dbs");
        }
    }
}
