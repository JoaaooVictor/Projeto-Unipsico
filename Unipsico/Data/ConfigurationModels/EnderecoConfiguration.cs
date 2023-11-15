using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unipsico.Models;

namespace Unipsico.Data.ConfigurationModels
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<EnderecoModel>
    {
        public void Configure(EntityTypeBuilder<EnderecoModel> builder)
        {
            builder
                .HasOne(e => e.InstituicaoCredenciada)
                .WithOne(i => i.Endereco)
                .HasForeignKey<InstituicaoCredenciadaModel>(e => e.EnderecoId);

            builder.
                HasKey(e => e.EnderecoId);
        }
    }
}
