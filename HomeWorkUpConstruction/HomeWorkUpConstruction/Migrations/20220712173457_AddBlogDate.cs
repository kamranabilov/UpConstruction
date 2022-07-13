using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWorkUpConstruction.Migrations
{
    public partial class AddBlogDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RelaseDate",
                table: "Blogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RelaseDate",
                table: "Blogs");
        }
    }
}
