using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWorkUpConstruction.Migrations
{
    public partial class createDBBranchType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BranchId",
                table: "Blogs",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Branches_BranchId",
                table: "Blogs",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Branches_BranchId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BranchId",
                table: "Blogs");
        }
    }
}
