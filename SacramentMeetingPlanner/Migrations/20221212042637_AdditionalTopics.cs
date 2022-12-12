using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class AdditionalTopics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TopicChoiceFour",
                table: "Meeting",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicChoiceThree",
                table: "Meeting",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicChoiceTwo",
                table: "Meeting",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopicChoiceFour",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "TopicChoiceThree",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "TopicChoiceTwo",
                table: "Meeting");
        }
    }
}
