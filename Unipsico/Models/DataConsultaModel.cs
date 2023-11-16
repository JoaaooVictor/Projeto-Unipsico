using Unipsico.Models.Enums.Consultas;

namespace Unipsico.Models
{
    public class DataConsultaModel
    {
        public Guid DataConsultaId { get; set; }
        public DateTime DataConsulta {  get; set; }
        public StatusConsulta StatusConsulta { get; set; }
        public virtual ConsultaModel Consulta { get; set; }
    }
}
