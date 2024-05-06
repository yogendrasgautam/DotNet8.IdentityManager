using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet8.IdentityManager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Initials",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Initials",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 4,
                oldNullable: true);
        }
    }
}
