using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unipsico.Migrations
{
    public partial class AplicandobooleanoTabelaDataDisponivel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<ulong>(
                name: "StatusConsulta",
                table: "DatasConsultas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StatusConsulta",
                table: "DatasConsultas",
                type: "int",
                nullable: false,
                oldClrType: typeof(ulong),
                oldType: "bit");
        }
    }
}
