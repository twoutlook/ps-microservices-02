using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GloboTicket.Services.EventCatalog.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea317"),
                column: "Date",
                value: new DateTime(2021, 6, 24, 10, 31, 14, 467, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea318"),
                column: "Date",
                value: new DateTime(2021, 8, 24, 10, 31, 14, 470, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea319"),
                column: "Date",
                value: new DateTime(2021, 9, 24, 10, 31, 14, 470, DateTimeKind.Local).AddTicks(9038));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea317"),
                column: "Date",
                value: new DateTime(2021, 1, 11, 16, 22, 42, 250, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea318"),
                column: "Date",
                value: new DateTime(2021, 3, 11, 16, 22, 42, 252, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea319"),
                column: "Date",
                value: new DateTime(2021, 4, 11, 16, 22, 42, 252, DateTimeKind.Local).AddTicks(5753));
        }
    }
}
