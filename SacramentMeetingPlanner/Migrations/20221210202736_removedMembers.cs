using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class removedMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Member_MemberId",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Meeting_MeetingId",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_MeetingId",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_MemberId",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "MeetingId",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Meeting");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MeetingId",
                table: "Member",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Meeting",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Member_MeetingId",
                table: "Member",
                column: "MeetingId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Meeting_MeetingId",
                table: "Member",
                column: "MeetingId",
                principalTable: "Meeting",
                principalColumn: "Id");
        }
    }
}
