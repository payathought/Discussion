using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Discussion.Repository.Migrations
{
    public partial class UpdateEntityMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discussion_User_CreatedById",
                schema: "discussions",
                table: "Discussion");

            migrationBuilder.DropForeignKey(
                name: "FK_Discussion_User_ObserverId",
                schema: "discussions",
                table: "Discussion");

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b411d1f-8c24-401c-9a93-6eba12084334"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 36, 19, 649, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("557d9b82-bc9b-484d-94aa-6917ade6c65f"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 36, 19, 649, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("73a27840-ba70-4c90-866b-9246c779ca15"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 36, 19, 649, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 36, 19, 648, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eaba0a44-f143-41d8-ac94-ef7a4ac66a27"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 36, 19, 649, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f21c3f39-c8d3-4acc-84ec-45cbdf6d9189"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 36, 19, 649, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.AddForeignKey(
                name: "FK_Discussion_User_CreatedById",
                schema: "discussions",
                table: "Discussion",
                column: "CreatedById",
                principalSchema: "users",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Discussion_User_ObserverId",
                schema: "discussions",
                table: "Discussion",
                column: "ObserverId",
                principalSchema: "users",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discussion_User_CreatedById",
                schema: "discussions",
                table: "Discussion");

            migrationBuilder.DropForeignKey(
                name: "FK_Discussion_User_ObserverId",
                schema: "discussions",
                table: "Discussion");

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b411d1f-8c24-401c-9a93-6eba12084334"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 32, 14, 907, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("557d9b82-bc9b-484d-94aa-6917ade6c65f"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 32, 14, 907, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("73a27840-ba70-4c90-866b-9246c779ca15"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 32, 14, 907, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 32, 14, 906, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eaba0a44-f143-41d8-ac94-ef7a4ac66a27"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 32, 14, 907, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f21c3f39-c8d3-4acc-84ec-45cbdf6d9189"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 32, 14, 907, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.AddForeignKey(
                name: "FK_Discussion_User_CreatedById",
                schema: "discussions",
                table: "Discussion",
                column: "CreatedById",
                principalSchema: "users",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Discussion_User_ObserverId",
                schema: "discussions",
                table: "Discussion",
                column: "ObserverId",
                principalSchema: "users",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
