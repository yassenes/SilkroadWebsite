using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SilkroadWebsite.Migrations
{
    /// <inheritdoc />
    public partial class PostAddImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "_Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "_Posts");
        }
    }
}
