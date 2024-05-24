using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskPlanner.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserSettingsRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    WorkInterval = table.Column<int>(type: "integer", nullable: false, defaultValue: 50),
                    BreakInterval = table.Column<int>(type: "integer", nullable: false, defaultValue: 10),
                    IntervalsCount = table.Column<int>(type: "integer", nullable: false, defaultValue: 7)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserSettings_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSettings");
        }
    }
}
