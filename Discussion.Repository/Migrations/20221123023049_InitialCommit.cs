using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Discussion.Repository.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "users");

            migrationBuilder.CreateTable(
                name: "User",
                schema: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "users",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "users",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedById",
                schema: "users",
                table: "User",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_User_ModifiedById",
                schema: "users",
                table: "User",
                column: "ModifiedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User",
                schema: "users");
        }
    }
}
