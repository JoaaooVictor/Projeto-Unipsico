namespace Unipsico.Models
{
    public class AlunoModel
    {
        public Guid AlunoId { get; set; }
        public string NomeAluno { get; set; }
        public string RaAluno { get; set; }
        public int IdadeAluno { get; set; }
        public string SalaAluno { get; set; }
        public DateTime DataRegistro => DateTime.Now;
        public virtual ConsultaModel Consulta { get; set; }
        public virtual List<EstagioModel>? Estagio { get; set; }
    }
}
