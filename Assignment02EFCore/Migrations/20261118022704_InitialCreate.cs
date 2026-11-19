using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment02EFCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Attendees",
                columns: table => new
                {
                    AttendeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Street = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    City = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.AttendeeId);
                });

            migrationBuilder.CreateTable(
                name: "Badges",
                columns: table => new
                {
                    BadgeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BadgeNumber = table.Column<int>(type: "int", nullable: false),
                    DateIssued = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tier = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badges", x => x.BadgeId);
                });

            migrationBuilder.CreateTable(
                name: "EventOrganizers",
                schema: "dbo",
                columns: table => new
                {
                    OrganizerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    CompanyName = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOrganizers", x => x.OrganizerId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaxAttendees = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "OrganizerProfiles",
                columns: table => new
                {
                    OrganizerProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Biography = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    WebsiteUrl = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    LogoUrl = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizerProfiles", x => x.OrganizerProfileId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendees");

            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropTable(
                name: "EventOrganizers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "OrganizerProfiles");
        }
    }
}
