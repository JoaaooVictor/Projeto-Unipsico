using Unipsico.Models.Enums.Pacientes;

namespace Unipsico.Models
{
    public class AlunoModel
    {
        public Guid AlunoId { get; set; }
        public string NomeAluno { get; set; }
        public string CpfAluno { get; set; }
        public string RaAluno { get; set; }
        public string SalaAluno { get; set; }
        public string CelularAluno { get; set; }
        public StatusUsuarios StatusAluno { get; set; }
        public DateTime DataRegistro { get; set; } = DateTime.Now;
        public virtual ICollection<ConsultaModel>? Consultas { get; set; }
        public virtual ICollection<EstagioModel>? Estagios { get; set; }
    }
}
