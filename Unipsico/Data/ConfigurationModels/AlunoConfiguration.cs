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
                .HasOne(c => c.Consulta)
                .WithOne(c => c.Aluno)
                .HasForeignKey<ConsultaModel>(a => a.AlunoId);

            builder
                .HasKey(c => c.AlunoId);
        }
    }
}
