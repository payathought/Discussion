using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Discussion.Repository.Migrations
{
    public partial class AddedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 17, 0, 21, 213, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.InsertData(
                schema: "users",
                table: "User",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Deleted", "FirstName", "LastName", "ModifiedById", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0b411d1f-8c24-401c-9a93-6eba12084334"), new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"), new DateTime(2023, 3, 9, 17, 0, 21, 214, DateTimeKind.Local).AddTicks(4412), false, "Adam", "Smith", null, null },
                    { new Guid("f21c3f39-c8d3-4acc-84ec-45cbdf6d9189"), new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"), new DateTime(2023, 3, 9, 17, 0, 21, 214, DateTimeKind.Local).AddTicks(4426), false, "Joe", "Parker", null, null },
                    { new Guid("eaba0a44-f143-41d8-ac94-ef7a4ac66a27"), new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"), new DateTime(2023, 3, 9, 17, 0, 21, 214, DateTimeKind.Local).AddTicks(4430), false, "Patrick", "Gargoles", null, null },
                    { new Guid("73a27840-ba70-4c90-866b-9246c779ca15"), new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"), new DateTime(2023, 3, 9, 17, 0, 21, 214, DateTimeKind.Local).AddTicks(4433), false, "Shannon", "Jones", null, null },
                    { new Guid("557d9b82-bc9b-484d-94aa-6917ade6c65f"), new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"), new DateTime(2023, 3, 9, 17, 0, 21, 214, DateTimeKind.Local).AddTicks(4435), false, "Hurish", "Williams", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b411d1f-8c24-401c-9a93-6eba12084334"));

            migrationBuilder.DeleteData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("557d9b82-bc9b-484d-94aa-6917ade6c65f"));

            migrationBuilder.DeleteData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("73a27840-ba70-4c90-866b-9246c779ca15"));

            migrationBuilder.DeleteData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eaba0a44-f143-41d8-ac94-ef7a4ac66a27"));

            migrationBuilder.DeleteData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f21c3f39-c8d3-4acc-84ec-45cbdf6d9189"));

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 16, 55, 45, 48, DateTimeKind.Local).AddTicks(4606));
        }
    }
}
