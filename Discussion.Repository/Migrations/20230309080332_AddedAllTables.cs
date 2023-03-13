using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Discussion.Repository.Migrations
{
    public partial class AddedAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "discussions");

            migrationBuilder.EnsureSchema(
                name: "discussionUsers");

            migrationBuilder.CreateTable(
                name: "Discussion",
                schema: "discussions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObserverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Outcomes = table.Column<string>(type: "nvarchar(max)", maxLength: 5124, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discussion_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "users",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discussion_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "users",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discussion_User_ObserverId",
                        column: x => x.ObserverId,
                        principalSchema: "users",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscussionUser",
                schema: "discussionUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscussionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscussionUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscussionUser_Discussion_DiscussionId",
                        column: x => x.DiscussionId,
                        principalSchema: "discussions",
                        principalTable: "Discussion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscussionUser_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "users",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiscussionUser_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "users",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiscussionUser_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "users",
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 9, 16, 3, 31, 762, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.CreateIndex(
                name: "IX_Discussion_CreatedById",
                schema: "discussions",
                table: "Discussion",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Discussion_ModifiedById",
                schema: "discussions",
                table: "Discussion",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Discussion_ObserverId",
                schema: "discussions",
                table: "Discussion",
                column: "ObserverId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionUser_CreatedById",
                schema: "discussionUsers",
                table: "DiscussionUser",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionUser_DiscussionId",
                schema: "discussionUsers",
                table: "DiscussionUser",
                column: "DiscussionId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionUser_ModifiedById",
                schema: "discussionUsers",
                table: "DiscussionUser",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionUser_UserId",
                schema: "discussionUsers",
                table: "DiscussionUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscussionUser",
                schema: "discussionUsers");

            migrationBuilder.DropTable(
                name: "Discussion",
                schema: "discussions");

            migrationBuilder.UpdateData(
                schema: "users",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c7bf03eb-2696-4c5e-a2b0-228854fc81c8"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 23, 10, 37, 57, 491, DateTimeKind.Local).AddTicks(7845));
        }
    }
}
