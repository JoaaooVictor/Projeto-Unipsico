using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unipsico.Models;

namespace Unipsico.Data.ConfigurationModels
{
    public class PacienteConfiguration : IEntityTypeConfiguration<PacienteModel>
    {
        public void Configure(EntityTypeBuilder<PacienteModel> builder)
        {
            builder.
                HasKey(p => p.PacienteId);

            builder
                .HasMany(p => p.Consultas)
                .WithOne(a => a.Paciente)
                .HasForeignKey(a => a.PacienteId);
            builder
                .HasIndex(p => p.CpfPaciente)
                .IsUnique();
        }
    }
}
