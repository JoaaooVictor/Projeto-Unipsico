namespace Unipsico.Models
{
    public class PacienteModel
    {
        public Guid PacienteId { get; set; }
        public string NomePaciente { get; set; }
        public int IdadePaciente  { get; set; }
        public string CpfPaciente { get; set; }
        public string CelularPaciente { get; set; }
        public string EmailPaciente { get; set; }
        public virtual ICollection<ConsultaModel> Consultas { get; set; }

    }
}
