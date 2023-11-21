﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Unipsico.Data;

#nullable disable

namespace Unipsico.Migrations
{
    [DbContext(typeof(ApplicationDB))]
    partial class ApllicationDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Unipsico.Models.AlunoModel", b =>
                {
                    b.Property<Guid>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CelularAluno")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CpfAluno")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeAluno")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RaAluno")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SalaAluno")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<short>("StatusAluno")
                        .HasColumnType("smallint");

                    b.HasKey("AlunoId");

                    b.HasIndex("CpfAluno")
                        .IsUnique();

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Unipsico.Models.ConsultaModel", b =>
                {
                    b.Property<Guid>("ConsultaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DataConsultaId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ProfessorId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ConsultaId");

                    b.HasIndex("AlunoId");

                    b.HasIndex("DataConsultaId")
                        .IsUnique();

                    b.HasIndex("PacienteId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("Unipsico.Models.DataConsultaModel", b =>
                {
                    b.Property<Guid>("DataConsultaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("datetime(6)");

                    b.Property<short>("StatusConsulta")
                        .HasColumnType("smallint");

                    b.HasKey("DataConsultaId");

                    b.ToTable("DatasConsultas");
                });

            modelBuilder.Entity("Unipsico.Models.EnderecoModel", b =>
                {
                    b.Property<Guid>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Unipsico.Models.EstagioModel", b =>
                {
                    b.Property<Guid>("EstagioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataEstagio")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("InstituicaoCredenciadaId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ProfessorId")
                        .HasColumnType("char(36)");

                    b.HasKey("EstagioId");

                    b.HasIndex("AlunoId");

                    b.HasIndex("InstituicaoCredenciadaId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Estagios");
                });

            modelBuilder.Entity("Unipsico.Models.InstituicaoCredenciadaModel", b =>
                {
                    b.Property<Guid>("InstituicaoCredenciadaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("NomeInstituicao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("InstituicaoCredenciadaId");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("InstituicoesCredenciadas");
                });

            modelBuilder.Entity("Unipsico.Models.PacienteModel", b =>
                {
                    b.Property<Guid>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CelularPaciente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CpfPaciente")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EmailPaciente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdadePaciente")
                        .HasColumnType("int");

                    b.Property<string>("NomePaciente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<short>("StatusPaciente")
                        .HasColumnType("smallint");

                    b.HasKey("PacienteId");

                    b.HasIndex("CpfPaciente")
                        .IsUnique();

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("Unipsico.Models.ProfessorModel", b =>
                {
                    b.Property<Guid>("ProfessorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CelularProfessor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CpfProfessor")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeProfessor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RpProfessor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<short>("StatusProfessor")
                        .HasColumnType("smallint");

                    b.HasKey("ProfessorId");

                    b.HasIndex("CpfProfessor")
                        .IsUnique();

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Unipsico.Models.ConsultaModel", b =>
                {
                    b.HasOne("Unipsico.Models.AlunoModel", "Aluno")
                        .WithMany("Consultas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unipsico.Models.DataConsultaModel", "DataConsulta")
                        .WithOne("Consulta")
                        .HasForeignKey("Unipsico.Models.ConsultaModel", "DataConsultaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unipsico.Models.PacienteModel", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unipsico.Models.ProfessorModel", "Professor")
                        .WithMany("Consultas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("DataConsulta");

                    b.Navigation("Paciente");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Unipsico.Models.EstagioModel", b =>
                {
                    b.HasOne("Unipsico.Models.AlunoModel", "Aluno")
                        .WithMany("Estagios")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unipsico.Models.InstituicaoCredenciadaModel", "InstituicaoCredenciada")
                        .WithMany("Estagios")
                        .HasForeignKey("InstituicaoCredenciadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unipsico.Models.ProfessorModel", "Professor")
                        .WithMany("Estagios")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("InstituicaoCredenciada");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Unipsico.Models.InstituicaoCredenciadaModel", b =>
                {
                    b.HasOne("Unipsico.Models.EnderecoModel", "Endereco")
                        .WithOne("InstituicaoCredenciada")
                        .HasForeignKey("Unipsico.Models.InstituicaoCredenciadaModel", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Unipsico.Models.AlunoModel", b =>
                {
                    b.Navigation("Consultas");

                    b.Navigation("Estagios");
                });

            modelBuilder.Entity("Unipsico.Models.DataConsultaModel", b =>
                {
                    b.Navigation("Consulta")
                        .IsRequired();
                });

            modelBuilder.Entity("Unipsico.Models.EnderecoModel", b =>
                {
                    b.Navigation("InstituicaoCredenciada");
                });

            modelBuilder.Entity("Unipsico.Models.InstituicaoCredenciadaModel", b =>
                {
                    b.Navigation("Estagios");
                });

            modelBuilder.Entity("Unipsico.Models.PacienteModel", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("Unipsico.Models.ProfessorModel", b =>
                {
                    b.Navigation("Consultas");

                    b.Navigation("Estagios");
                });
#pragma warning restore 612, 618
        }
    }
}
