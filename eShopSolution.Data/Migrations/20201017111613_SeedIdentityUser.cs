using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 17, 18, 16, 12, 333, DateTimeKind.Local).AddTicks(8125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 17, 17, 46, 13, 100, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FistName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"), 0, "bb1f6c5f-de57-48bf-a16d-f72ce67b5c45", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "anhquandemo@gmail.com", true, "Quan", "Anh", false, null, "anhquandemo@gmail.com", "admin", "AQAAAAEAACcQAAAAEMszjLm1zTHxJhDVGdlkJl1bhj2VqgwNWzaINcbHlyZDjwlCYdNkeDseKK37F9s/iw==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"), new Guid("a17d61e2-b8f0-42b4-8693-504ee2a44a5a") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 17, 18, 16, 12, 352, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("a17d61e2-b8f0-42b4-8693-504ee2a44a5a"), "04ea32f0-2e3b-40b6-aec1-957e785e6b92", "Administrator role", "admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"));

            migrationBuilder.DeleteData(
                table: "AppUserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"), new Guid("a17d61e2-b8f0-42b4-8693-504ee2a44a5a") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a17d61e2-b8f0-42b4-8693-504ee2a44a5a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 17, 17, 46, 13, 100, DateTimeKind.Local).AddTicks(7442),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 17, 18, 16, 12, 333, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 17, 17, 46, 13, 119, DateTimeKind.Local).AddTicks(8620));
        }
    }
}
