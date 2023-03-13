﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Discussion.Repository.Migrations
{
    public partial class UpdateMapRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: new DateTime(2023, 3, 9, 17, 43, 57, 784, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("557d9b82-bc9b-484d-94aa-6917ade6c65f"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 43, 57, 784, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("73a27840-ba70-4c90-866b-9246c779ca15"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 43, 57, 784, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 43, 57, 783, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eaba0a44-f143-41d8-ac94-ef7a4ac66a27"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 43, 57, 784, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f21c3f39-c8d3-4acc-84ec-45cbdf6d9189"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 43, 57, 784, DateTimeKind.Local).AddTicks(2171));

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
                name: "FK_Discussion_User_ObserverId",
                schema: "discussions",
                table: "Discussion");

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b411d1f-8c24-401c-9a93-6eba12084334"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 37, 18, 699, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("557d9b82-bc9b-484d-94aa-6917ade6c65f"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 37, 18, 699, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("73a27840-ba70-4c90-866b-9246c779ca15"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 37, 18, 699, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 37, 18, 699, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eaba0a44-f143-41d8-ac94-ef7a4ac66a27"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 37, 18, 699, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f21c3f39-c8d3-4acc-84ec-45cbdf6d9189"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 37, 18, 699, DateTimeKind.Local).AddTicks(6671));

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
