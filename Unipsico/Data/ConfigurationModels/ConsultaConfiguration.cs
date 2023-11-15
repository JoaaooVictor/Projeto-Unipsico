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
                .Property(c => c.DataConsulta)
                .IsRequired();
        }
    }
}
