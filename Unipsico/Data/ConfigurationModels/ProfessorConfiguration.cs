using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unipsico.Models;

namespace Unipsico.Data.ConfigurationModels
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<ProfessorModel>
    {
        public void Configure(EntityTypeBuilder<ProfessorModel> builder)
        {
            builder
                .HasKey(p => p.ProfessorId);

            builder
                .HasMany(p => p.Consultas)
                .WithOne(p => p.Professor)
                .HasForeignKey(p => p.ProfessorId);

            builder
                .HasMany(p => p.Estagios)
                .WithOne(p => p.Professor)  
                .HasForeignKey(p => p.ProfessorId);

            builder
                .HasIndex(p => p.CpfProfessor)
                .IsUnique();
        }
    }
}
