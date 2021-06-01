using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductsApi.Migrations
{
    public partial class seedDataAddedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 1, 14, 53, 55, 15, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 1, 14, 53, 55, 15, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 1, 14, 53, 55, 15, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DateCreated", "Description", "Link", "Name", "Price" },
                values: new object[] { 4, new DateTime(2021, 6, 1, 14, 53, 55, 15, DateTimeKind.Utc).AddTicks(8890), "Software Consulting", "https://www.xerris.com/images/xerris-logo.svg", "Xerris", 100000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 1, 14, 50, 3, 137, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 1, 14, 50, 3, 137, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 1, 14, 50, 3, 137, DateTimeKind.Utc).AddTicks(6490));
        }
    }
}
