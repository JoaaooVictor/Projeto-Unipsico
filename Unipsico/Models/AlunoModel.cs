namespace Unipsico.Models
{
    public class AlunoModel
    {
        public Guid AlunoId { get; set; }
        public string NomeAluno { get; set; }
        public string RaAluno { get; set; }
        public int IdadeAluno { get; set; }
        public string SalaAluno { get; set; }
        public DateTime DataRegistro { get; set; } = DateTime.Now;
        public virtual ICollection<ConsultaModel>? Consulta { get; set; }
        public virtual ICollection<EstagioModel>? Estagio { get; set; }
    }
}
