using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDone = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "Priority", "Title" },
                values: new object[] { new Guid("a2c4e6f8-9b7d-4a3c-8f1e-0d9c8b7a6e5d"), "Complete the summary and send to manager", new DateTime(2026, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, "Finish project report" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "Title" },
                values: new object[] { new Guid("c0b1a2d3-e4f5-6789-abcd-0123456789ab"), "Fix kitchen sink leak", new DateTime(2026, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Call plumber" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "IsDone", "Title" },
                values: new object[] { new Guid("d4e5f6a7-b8c9-4d3e-9f0a-1234abcd5678"), "Read 50 pages of the new novel", new DateTime(2026, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), true, "Read book" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "Priority", "Title" },
                values: new object[] { new Guid("f3b5a1d2-1c9b-4f2e-9e2a-8a1b2c3d4e5f"), "Milk, eggs, bread", new DateTime(2026, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, "Buy groceries" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_DueDate",
                table: "Todos",
                column: "DueDate");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_IsDone",
                table: "Todos",
                column: "IsDone");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_Priority",
                table: "Todos",
                column: "Priority");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
