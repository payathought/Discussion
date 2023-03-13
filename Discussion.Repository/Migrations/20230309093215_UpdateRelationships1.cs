using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Discussion.Repository.Migrations
{
    public partial class UpdateRelationships1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiscussionUser_User_UserId",
                schema: "discussionUsers",
                table: "DiscussionUser");

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
                name: "FK_DiscussionUser_User_UserId",
                schema: "discussionUsers",
                table: "DiscussionUser",
                column: "UserId",
                principalSchema: "users",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiscussionUser_User_UserId",
                schema: "discussionUsers",
                table: "DiscussionUser");

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b411d1f-8c24-401c-9a93-6eba12084334"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 31, 39, 803, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("557d9b82-bc9b-484d-94aa-6917ade6c65f"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 31, 39, 803, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("73a27840-ba70-4c90-866b-9246c779ca15"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 31, 39, 803, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 31, 39, 802, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eaba0a44-f143-41d8-ac94-ef7a4ac66a27"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 31, 39, 803, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f21c3f39-c8d3-4acc-84ec-45cbdf6d9189"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 31, 39, 803, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.AddForeignKey(
                name: "FK_DiscussionUser_User_UserId",
                schema: "discussionUsers",
                table: "DiscussionUser",
                column: "UserId",
                principalSchema: "users",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
