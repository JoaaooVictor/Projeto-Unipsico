using Unipsico.Models;

namespace Unipsico.Services.Interfaces
{
    public interface IEstagioServices
    {
        Task<IEnumerable<EstagioModel>> ObterTodosEstagios();
        Task<EstagioModel> ObterEstagioPorId(Guid id);
        Task AdicionarEstagio(EstagioModel estagio);
        Task AtualizarEstagio(EstagioModel estagio);
        Task ExcluirEstagio(Guid id);
    }
}
