using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unipsico.Models;

namespace Unipsico.Data.ConfigurationModels
{
    public class AlunoConfiguration : IEntityTypeConfiguration<AlunoModel>
    {
        public void Configure(EntityTypeBuilder<AlunoModel> builder)
        {
            builder
                .HasKey(c => c.AlunoId);

            builder
                .Property(p => p.StatusAluno)
                .HasColumnType("smallint");

            builder
                .HasMany(a => a.Consultas)
                .WithOne(a => a.Aluno)
                .HasForeignKey(a => a.AlunoId);

            builder
                .HasMany(e => e.Estagios)
                .WithOne(a => a.Aluno)
                .HasForeignKey(a => a.AlunoId);
            builder
                .HasIndex(a => a.CpfAluno)
                .IsUnique();
        }
    }
}
