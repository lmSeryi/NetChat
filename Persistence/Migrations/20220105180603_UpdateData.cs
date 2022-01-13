using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("9c6183f0-c3f6-40a5-9899-0768a8170b87"), "Description 1", "Channel 1" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("2bcd62de-9724-4ea7-8c07-0b0c4e2d4409"), "Description 2", "Channel 2" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("cbf09cb0-a44b-4f9a-9d95-e4a3610147cf"), "Description 3", "Channel 3" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("6cac539c-2f6d-47d2-9f78-a26ea42ab334"), "Description 4", "Channel 4" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("feb35746-44f4-47b2-a1e6-008333bcddf1"), "Description 5", "Channel 5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("2bcd62de-9724-4ea7-8c07-0b0c4e2d4409"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("6cac539c-2f6d-47d2-9f78-a26ea42ab334"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("9c6183f0-c3f6-40a5-9899-0768a8170b87"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("cbf09cb0-a44b-4f9a-9d95-e4a3610147cf"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("feb35746-44f4-47b2-a1e6-008333bcddf1"));

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
    }
}
