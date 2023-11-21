using Unipsico.Models;

namespace Unipsico.Services.Interfaces
{
    public interface IDataConsultaServices
    {
        Task<IEnumerable<DataConsultaModel>> ObterDatasDisponiveis();
        Task<IEnumerable<DataConsultaModel>> ObterDatasCanceladas();
        Task<IEnumerable<DataConsultaModel>> ObterDatasAgendadas();
        Task<IEnumerable<DataConsultaModel>> ObterDatasRealizadas();
        Task<IEnumerable<DataConsultaModel>> ObterDatasRemarcadas();
        Task AdicionarDataConsulta(DataConsultaModel dataConsulta);
        Task AtualizarDataConsulta(DataConsultaModel dataConsulta);
        Task ExcluirDataConsulta(Guid id);
    }
}
