using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class UpdatingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeetingId",
                table: "Meeting",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Meeting",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_MemberId",
                table: "Meeting",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Member_MemberId",
                table: "Meeting",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Member_MemberId",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_MemberId",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MeetingId",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Meeting");
        }
    }
}
