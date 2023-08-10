using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagement.MVC.Migrations
{
    public partial class ForVolumeProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "VolumeOfProduct",
                schema: "Identity",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VolumeOfProduct",
                schema: "Identity",
                table: "Orders");
        }
    }
}
