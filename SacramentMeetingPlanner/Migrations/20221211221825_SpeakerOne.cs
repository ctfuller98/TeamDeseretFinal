using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class SpeakerOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Member");

            migrationBuilder.RenameColumn(
                name: "MeetingId",
                table: "Meeting",
                newName: "TopicChoice");

            migrationBuilder.AddColumn<string>(
                name: "SpeakerOne",
                table: "Meeting",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpeakerOne",
                table: "Meeting");

            migrationBuilder.RenameColumn(
                name: "TopicChoice",
                table: "Meeting",
                newName: "MeetingId");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
