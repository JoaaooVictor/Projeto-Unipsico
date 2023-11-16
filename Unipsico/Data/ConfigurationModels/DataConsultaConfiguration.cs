using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unipsico.Models;

namespace Unipsico.Data.ConfigurationModels
{
    public class DataConsultaConfiguration : IEntityTypeConfiguration<DataConsultaModel>
    {
        public void Configure(EntityTypeBuilder<DataConsultaModel> builder)
        {
            builder
                .HasKey(d => d.DataConsultaId);

            builder
                .HasOne(d => d.Consulta)
                .WithOne(c => c.DataConsulta)
                .HasForeignKey<ConsultaModel>(c => c.DataConsultaId);
        }
    }
}
