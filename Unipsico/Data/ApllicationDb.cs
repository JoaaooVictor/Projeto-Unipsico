using Microsoft.EntityFrameworkCore;
using Unipsico.Data.ConfigurationModels;
using Unipsico.Models;

namespace Unipsico.Data
{
    public class ApllicationDb : DbContext
    {
        public ApllicationDb(DbContextOptions options) : base(options) { }
        public DbSet<AlunoModel> Alunos { get; set; }
        public DbSet<ProfessorModel> Professores { get; set; }
        public DbSet<PacienteModel> Pacientes { get; set; }
        public DbSet<ConsultaModel> Consultas { get; set; }
        public DbSet<EnderecoModel> Enderecos { get; set; }
        public DbSet<EstagioModel> Estagios { get; set; }
        public DbSet<InstituicaoCredenciadaModel> InstituicoesCredenciadas { get; set; }
        public DbSet<DataConsultaModel> DatasConsultas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new ConsultaConfiguration());
            modelBuilder.ApplyConfiguration(new EstagioConfiguration());
            modelBuilder.ApplyConfiguration(new PacienteConfiguration());
            modelBuilder.ApplyConfiguration(new InstituicaoCredenciadaConfiguration());
            modelBuilder.ApplyConfiguration(new DataConsultaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
