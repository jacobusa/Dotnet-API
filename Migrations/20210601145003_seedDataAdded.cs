using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProductsApi.Migrations
{
    public partial class seedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DateCreated", "Description", "Link", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 6, 1, 14, 50, 3, 137, DateTimeKind.Utc).AddTicks(5240), "Most valuable precious metal", "https://responsive.fxempire.com/v7/_fxempire_/2020/06/Gold-11.jpg?func=cover&q70&width=615", "Gold", 12000m },
                    { 2, new DateTime(2021, 6, 1, 14, 50, 3, 137, DateTimeKind.Utc).AddTicks(6480), "Second most valuable precious metal", "https://e7j3v5v7.rocketcdn.me/wp-content/uploads/2020/05/327446-silver-1024x640.jpg", "Silver", 6000m },
                    { 3, new DateTime(2021, 6, 1, 14, 50, 3, 137, DateTimeKind.Utc).AddTicks(6490), "Digital Gold", "https://i.guim.co.uk/img/media/09de088fe70256cfae7c4bc42b6cded754545133/0_66_3500_2100/master/3500.jpg?width=620&quality=85&auto=format&fit=max&s=5d8ef8483e18802012c16ef18a7f9568", "Bitcoin", 40000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
