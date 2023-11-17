using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unipsico.Migrations
{
    public partial class StatusUsuariosAplicadosModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "StatusProfessor",
                table: "Professores",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataRegistro",
                table: "Pacientes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<short>(
                name: "StatusPaciente",
                table: "Pacientes",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AlterColumn<short>(
                name: "StatusConsulta",
                table: "DatasConsultas",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(ulong),
                oldType: "bit");

            migrationBuilder.AddColumn<short>(
                name: "StatusAluno",
                table: "Alunos",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusProfessor",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "DataRegistro",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "StatusPaciente",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "StatusAluno",
                table: "Alunos");

            migrationBuilder.AlterColumn<ulong>(
                name: "StatusConsulta",
                table: "DatasConsultas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }
    }
}
