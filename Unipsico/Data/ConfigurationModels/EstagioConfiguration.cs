﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unipsico.Models;

namespace Unipsico.Data.ConfigurationModels
{
    public class EstagioConfiguration : IEntityTypeConfiguration<EstagioModel>
    {
        public void Configure(EntityTypeBuilder<EstagioModel> builder)
        {
            builder
                .HasKey(e => e.EstagioId);

            builder
                .HasOne(e => e.InstituicaoCredenciada)
                .WithMany(i => i.Estagios)
                .HasForeignKey(e => e.InstituicaoCredenciadaId);

            builder
                .HasOne(p => p.Professor)
                .WithMany(e => e.Estagios)
                .HasForeignKey(p => p.ProfessorId);
            builder
                .HasOne(a => a.Aluno)
                .WithMany(e => e.Estagios)
                .HasForeignKey(a => a.AlunoId);
        }
    }
}