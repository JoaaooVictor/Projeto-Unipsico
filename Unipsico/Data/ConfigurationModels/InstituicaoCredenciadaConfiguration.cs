using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unipsico.Models;

namespace Unipsico.Data.ConfigurationModels
{
    public class InstituicaoCredenciadaConfiguration : IEntityTypeConfiguration<InstituicaoCredenciadaModel>
    {
        public void Configure(EntityTypeBuilder<InstituicaoCredenciadaModel> builder)
        {
            builder
                .HasKey(i => i.InstituicaoId);
        }
    }
}

