using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class RemovedSpeakerAndTopicNoCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpeakerOne",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "TopicChoice",
                table: "Meeting");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpeakerOne",
                table: "Meeting",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TopicChoice",
                table: "Meeting",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
