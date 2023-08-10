using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagement.MVC.Migrations
{
    public partial class ChangeOrderModul : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfProduct",
                schema: "Identity",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "VolumeOfProduct",
                schema: "Identity",
                table: "Orders",
                newName: "VolumeProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VolumeProduct",
                schema: "Identity",
                table: "Orders",
                newName: "VolumeOfProduct");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfProduct",
                schema: "Identity",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
