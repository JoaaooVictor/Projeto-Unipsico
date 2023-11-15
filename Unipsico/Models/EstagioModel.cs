namespace Unipsico.Models
{
    public class EstagioModel
    {
        public Guid EstagioId { get; set; }
        public DateTime DataEstagio { get; set; }
        public Guid AlunoId { get; set; }
        public AlunoModel Aluno { get; set; }
        public Guid ProfessorId { get; set; }
        public ProfessorModel Professor { get; set; }
        public Guid InstituicaoCredenciadaId { get; set; }
        public InstituicaoCredenciadaModel InstituicaoCredenciada { get; set; }
    }
}