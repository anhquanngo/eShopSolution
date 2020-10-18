using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 18, 19, 4, 13, 447, DateTimeKind.Local).AddTicks(3585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 17, 18, 16, 12, 333, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2376bf3-f318-4462-a03e-8b6ec5be6d26", "AQAAAAEAACcQAAAAEIZtlRv1mdHFqjiHAPhgpH05w2DG35Quojb3KVPKgYUnCqdj/kK8rz2CCHb4UgwyXA==" });

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
                value: new DateTime(2020, 10, 18, 19, 4, 13, 470, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a17d61e2-b8f0-42b4-8693-504ee2a44a5a"),
                column: "ConcurrencyStamp",
                value: "4b1a1cb1-2613-4894-b227-2103c2398f48");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 17, 18, 16, 12, 333, DateTimeKind.Local).AddTicks(8125),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 18, 19, 4, 13, 447, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb1f6c5f-de57-48bf-a16d-f72ce67b5c45", "AQAAAAEAACcQAAAAEMszjLm1zTHxJhDVGdlkJl1bhj2VqgwNWzaINcbHlyZDjwlCYdNkeDseKK37F9s/iw==" });

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a17d61e2-b8f0-42b4-8693-504ee2a44a5a"),
                column: "ConcurrencyStamp",
                value: "04ea32f0-2e3b-40b6-aec1-957e785e6b92");
        }
    }
}
