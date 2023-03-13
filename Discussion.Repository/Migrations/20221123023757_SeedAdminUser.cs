using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Discussion.Repository.Migrations
{
    public partial class SeedAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "users",
                table: "User",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Deleted", "FirstName", "LastName", "ModifiedById", "ModifiedDate" },
                values: new object[] { new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"), new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"), new DateTime(2022, 11, 23, 10, 37, 57, 491, DateTimeKind.Local).AddTicks(7845), false, "Admin", "Admin", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"));
        }
    }
}
