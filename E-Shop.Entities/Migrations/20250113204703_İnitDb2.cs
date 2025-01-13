using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Shop.Entities.Migrations
{
    /// <inheritdoc />
    public partial class İnitDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "T-Shirt", null },
                    { 2, "Jacket", null },
                    { 3, "Mont", null },
                    { 4, "Shoes", null },
                    { 5, "Bags", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "Id", "CompanyName", "Phone" },
                values: new object[,]
                {
                    { 1, "JetKargo", "+90 555 444 55 55" },
                    { 2, "Aras Kargo", "444 25 52" },
                    { 3, "PTT Kargo", "+90 312 309 51 44" }
                });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 13, 23, 47, 3, 720, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 13, 23, 47, 3, 720, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 13, 23, 47, 3, 720, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 13, 23, 47, 3, 720, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Jacket" },
                    { 2, 1, "Shoes" },
                    { 3, 1, "Mont" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Gsm", "Name", "Password", "RoleId", "SurName" },
                values: new object[,]
                {
                    { 1, "hamza@gmail.com", "+90 555 555 55 55", "Hamza", "qweasd", 1, "Aydınlı" },
                    { 2, "furkan_yeneroğlu@gmail.com", "+90 555 555 55 44", "Mehmet", "qweasd", 2, "Kaya" },
                    { 3, "ahmet@gmail.com", "+90 555 555 55 33", "Ahmet", "qweasd", 2, "Yilmaz" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressDescription", "AddressName", "District", "MyUserId", "Province" },
                values: new object[,]
                {
                    { 1, "İstiklal Caddesi,Mehmet Akif Sokağı,Aydınlı Apartmanı No:6 / Daire:1", "Home", "Üsküdar", 1, "İstanbul" },
                    { 2, "Cantürk Sokak, Aydınlı Apt. No:28 Daire:4", "Evim", "Terme", 2, "Samsun" },
                    { 3, "Gökcan Mahallesi, Ateş Apartmanı No:14 Daire:2", "Office", "Canik", 3, "Samsun" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "PhotoPath", "Price", "StockQuantity", "SubCategoryId", "Title" },
                values: new object[] { 1, "Jacket", "/img/shopping-cart/cart-1.jpg", 400m, 4, 1, "Jacket" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "Freight", "MyUserId", "OrderDate", "RequiredDate", "ShippedDate", "ShipperId" },
                values: new object[] { 1, 1, 0m, 2, new DateOnly(2024, 10, 18), new DateOnly(2024, 10, 22), new DateOnly(2024, 10, 20), 1 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "Discount", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { 1, 0m, 1, 1, 1, 200m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 1, 23, 39, 19, 248, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 1, 23, 39, 19, 248, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 1, 23, 39, 19, 248, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 1, 23, 39, 19, 248, DateTimeKind.Local).AddTicks(4217));
        }
    }
}
