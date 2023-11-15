namespace Unipsico.Models
{
    public class ProfessorModel
    {
        public Guid ProfessorId { get; set; }
        public string NomeProfessor { get; set; }
        public virtual ICollection<ConsultaModel> Consulta { get; set; }
        public virtual ICollection<EstagioModel> Estagio { get; set; }
    }
}
