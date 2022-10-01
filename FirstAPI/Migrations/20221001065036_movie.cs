using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace FirstAPI.Migrations
{
    public partial class movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: true),
                    Genre = table.Column<string>(type: "longtext", nullable: true),
                    RealeseDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "user");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "user",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Id");
        }
    }
}
