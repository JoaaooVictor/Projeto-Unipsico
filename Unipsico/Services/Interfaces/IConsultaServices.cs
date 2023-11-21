using Unipsico.Models;

namespace Unipsico.Services.Interfaces
{
    public interface IConsultaService
    {
        Task<IEnumerable<ConsultaModel>> ObterTodasConsultas();
        Task<ConsultaModel> ObterConsultaPorId(Guid id);
        Task AdicionarConsulta(ConsultaModel consulta);
        Task AtualizarConsulta(ConsultaModel consulta);
        Task ExcluirConsulta(Guid id);
    }

}
