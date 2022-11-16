using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VerhuringCandyWebsite.Infrastructure.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ReservationOrder",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationOrder_ApplicationUserId",
                table: "ReservationOrder",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationOrder_AspNetUsers_ApplicationUserId",
                table: "ReservationOrder",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationOrder_AspNetUsers_ApplicationUserId",
                table: "ReservationOrder");

            migrationBuilder.DropIndex(
                name: "IX_ReservationOrder_ApplicationUserId",
                table: "ReservationOrder");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ReservationOrder");
        }
    }
}
