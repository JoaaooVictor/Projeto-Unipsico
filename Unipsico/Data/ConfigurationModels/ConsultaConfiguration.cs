using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unipsico.Models;

namespace Unipsico.Data.ConfigurationModels
{
    public class ConsultaConfiguration : IEntityTypeConfiguration<ConsultaModel>
    {
        public void Configure(EntityTypeBuilder<ConsultaModel> builder)
        {
            builder.
                 HasKey(c => c.ConsultaId);

            builder
                .HasOne(p => p.Paciente)
                .WithMany(c => c.Consultas)
                .HasForeignKey(c => c.PacienteId);

            builder
                .HasOne(a => a.Aluno)
                .WithMany(c => c.Consultas)
                .HasForeignKey(a => a.AlunoId);

            builder
                .HasOne(a => a.Professor)
                .WithMany(c => c.Consultas)
                .HasForeignKey(a => a.ProfessorId);

            builder
                .HasOne(c => c.DataConsulta)
                .WithOne(d => d.Consulta)
                .HasForeignKey<ConsultaModel>(d => d.DataConsultaId);
        }
    }
}
