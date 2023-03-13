using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Discussion.Repository.Migrations
{
    public partial class ChangeMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Discussion_ObserverId",
                schema: "discussions",
                table: "Discussion");

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b411d1f-8c24-401c-9a93-6eba12084334"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 8, 7, 563, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("557d9b82-bc9b-484d-94aa-6917ade6c65f"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 8, 7, 563, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("73a27840-ba70-4c90-866b-9246c779ca15"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 8, 7, 563, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 8, 7, 563, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eaba0a44-f143-41d8-ac94-ef7a4ac66a27"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 8, 7, 563, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f21c3f39-c8d3-4acc-84ec-45cbdf6d9189"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 8, 7, 563, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.CreateIndex(
                name: "IX_Discussion_ObserverId",
                schema: "discussions",
                table: "Discussion",
                column: "ObserverId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Discussion_ObserverId",
                schema: "discussions",
                table: "Discussion");

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b411d1f-8c24-401c-9a93-6eba12084334"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 0, 21, 214, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("557d9b82-bc9b-484d-94aa-6917ade6c65f"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 0, 21, 214, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("73a27840-ba70-4c90-866b-9246c779ca15"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 0, 21, 214, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 0, 21, 213, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eaba0a44-f143-41d8-ac94-ef7a4ac66a27"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 0, 21, 214, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f21c3f39-c8d3-4acc-84ec-45cbdf6d9189"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 0, 21, 214, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.CreateIndex(
                name: "IX_Discussion_ObserverId",
                schema: "discussions",
                table: "Discussion",
                column: "ObserverId");
        }
    }
}
