using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_7WebAPI.Migrations
{
    public partial class initTeam_7Api : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "leaveDetails_Dbs",
                columns: table => new
                {
                    Leave_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Id = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_leaveDetails_Dbs", x => x.Leave_ID);
                });

            migrationBuilder.CreateTable(
                name: "managerDetails_Dbs",
                columns: table => new
                {
                    Manager_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile_Number = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_managerDetails_Dbs", x => x.Manager_Id);
                });

            migrationBuilder.CreateTable(
                name: "employeeDetails_Dbs",
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
                    Manager_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeDetails_Dbs", x => x.Employee_Id);
                    table.ForeignKey(
                        name: "FK_employeeDetails_Dbs_managerDetails_Dbs_Manager_Id",
                        column: x => x.Manager_Id,
                        principalTable: "managerDetails_Dbs",
                        principalColumn: "Manager_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employeeDetails_Dbs_Manager_Id",
                table: "employeeDetails_Dbs",
                column: "Manager_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeeDetails_Dbs");

            migrationBuilder.DropTable(
                name: "leaveDetails_Dbs");

            migrationBuilder.DropTable(
                name: "managerDetails_Dbs");
        }
    }
}
