using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class updateMeetingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Member_MeetingId",
                table: "Member");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MeetingId",
                table: "Member",
                column: "MeetingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Member_MeetingId",
                table: "Member");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MeetingId",
                table: "Member",
                column: "MeetingId",
                unique: true);
        }
    }
}
