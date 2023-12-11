using Unipsico.Models;

namespace Unipsico.Services.Interfaces
{
    public interface IProfessorServices
    {
        Task<IEnumerable<ProfessorModel>> ObterTodosProfessores();
        Task<ProfessorModel> ObterProfessorPorId(Guid id);
        Task AdicionarProfessor(ProfessorModel professor);
        Task AtualizarProfessor(ProfessorModel professor);
        Task ExcluirProfessor(Guid id);
        Task<bool> ProfessorExistente(string numeroMatricula);
    }

}
