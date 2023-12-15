using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library.Migrations
{
    public partial class dt_seed_livros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "Created", "DataDePublicacao", "GeneroId", "ISBN", "Name", "Sinopse" },
                values: new object[] { 1, 1, new DateTime(2012, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "9788525427144", "Uma História do Mundo", null });
          }
         

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1);

            
        }
    }
}
