using Unipsico.Models.Enums.Consultas;

namespace Unipsico.Models
{
    public class ProfessorModel
    {
        public Guid ProfessorId { get; set; }
        public string NomeProfessor { get; set; }
        public string CpfProfessor { get; set; }
        public string RpProfessor { get; set; }
        public string CelularProfessor { get; set; }
        public DateTime DataRegistro { get; set; } = DateTime.Now;
        public StatusConsulta StatusProfessor { get; set; }
        public virtual ICollection<ConsultaModel> Consultas { get; set; }
        public virtual ICollection<EstagioModel> Estagios { get; set; }
    }
}
