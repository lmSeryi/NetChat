using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("5da78997-32ad-4846-b682-3f3110ce2aa1"), "Channel 1", "Channel 1" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("33cbf403-39c4-48d0-a41a-ef35cbfc372f"), "Channel 2", "Channel 2" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("729fafeb-615d-4384-876a-04ea11e09153"), "Channel 3", "Channel 3" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("4ba0e071-966d-48f9-8559-a6e3850a3515"), "Channel 4", "Channel 4" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("f878f08e-07b0-4eb5-b9e0-b3277d187250"), "Channel 5", "Channel 5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("33cbf403-39c4-48d0-a41a-ef35cbfc372f"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("4ba0e071-966d-48f9-8559-a6e3850a3515"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("5da78997-32ad-4846-b682-3f3110ce2aa1"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("729fafeb-615d-4384-876a-04ea11e09153"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("f878f08e-07b0-4eb5-b9e0-b3277d187250"));
        }
    }
}
