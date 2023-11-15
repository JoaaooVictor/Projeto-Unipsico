namespace Unipsico.Models
{
    public class ConsultaModel
    {
        public Guid ConsultaId { get; set; }
        public DateTime DataConsulta { get; set; }
        public Guid PacienteId { get; set; }
        public PacienteModel? Paciente { get; set; }
        public Guid AlunoId { get; set; }
        public AlunoModel? Aluno { get; set; }
        public Guid ProfessorId { get; set; }
        public ProfessorModel? Professor { get; set; }
    }
}
