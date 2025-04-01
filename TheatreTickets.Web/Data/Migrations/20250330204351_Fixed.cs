using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreTickets.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_OwnerId",
                table: "Ticket");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Ticket",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "Ticket",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_OwnerId",
                table: "Ticket",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_OwnerId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Ticket");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Ticket",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_OwnerId",
                table: "Ticket",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
