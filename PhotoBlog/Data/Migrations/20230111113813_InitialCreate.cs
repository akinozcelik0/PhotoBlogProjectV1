using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoBlog.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CreatedTime", "Description", "Photo", "Title" },
                values: new object[] { 1, new DateTime(2023, 1, 11, 14, 38, 13, 203, DateTimeKind.Local).AddTicks(4645), "Such AmAzInG,Much wOw, super ultimate picture of somewhere on 'Damnation' that we call Earth", "sample.jpg", "Mountains & Sea" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
