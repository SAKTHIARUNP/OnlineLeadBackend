using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLeadMgmt.Migrations
{
    /// <inheritdoc />
    public partial class sample : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Leads");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Leads",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
