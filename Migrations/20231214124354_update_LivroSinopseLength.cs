using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library.Migrations
{
    public partial class update_LivroSinopseLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sinopse",
                table: "Livro",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Created", "FirstName", "ImageFile", "LastName", "birth" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "0David_Coimbra_(2023).png", "Coimbra", new DateTime(1962, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

             }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 1);

            
            migrationBuilder.AlterColumn<string>(
                name: "Sinopse",
                table: "Livro",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600,
                oldNullable: true);
        }
    }
}
