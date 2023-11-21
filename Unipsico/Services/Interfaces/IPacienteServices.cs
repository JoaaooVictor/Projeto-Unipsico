using Unipsico.Models;

namespace Unipsico.Services.Interfaces
{
    public interface IPacienteServices
    {
        Task<IEnumerable<PacienteModel>> ObterTodosPacientes();
        Task<IEnumerable<PacienteModel>> ObterPacientesPorNome(string nome);
        Task<PacienteModel> ObterPacientePorConsulta(ConsultaModel consulta);
        Task<PacienteModel> ObterPacientePorId(Guid id);
        Task AdicionarPaciente(PacienteModel paciente);
        Task AtualizarPaciente(PacienteModel paciente);
        Task ExcluirPaciente(Guid id);
    }

}
