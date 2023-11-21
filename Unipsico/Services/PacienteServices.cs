using Microsoft.EntityFrameworkCore;
using Unipsico.Data;
using Unipsico.Models;
using Unipsico.Services.Interfaces;

namespace Unipsico.Services
{
    public class PacienteServices : IPacienteServices
    {
        private readonly ApplicationDB _ApplicationDB;

        public PacienteServices(ApplicationDB apllicationDb)
        {
            _ApplicationDB = apllicationDb;
        }
        public async Task AdicionarPaciente(PacienteModel paciente)
        {
            _ = _ApplicationDB.Pacientes.AddAsync(paciente);
            await _ApplicationDB.SaveChangesAsync();
        }

        public async Task AtualizarPaciente(PacienteModel paciente)
        {
            _ApplicationDB.Pacientes.Update(paciente);
            await _ApplicationDB.SaveChangesAsync();
        }

        public async Task ExcluirPaciente(Guid id)
        {
            var pacienteSalvoNoBanco = await _ApplicationDB.Pacientes.FindAsync(id);
            if(pacienteSalvoNoBanco != null )
            {
                _ApplicationDB.Pacientes.Remove(pacienteSalvoNoBanco);
                await _ApplicationDB.SaveChangesAsync();
            }
        }

        public async Task<PacienteModel> ObterPacientePorId(Guid id)
        {
            return await _ApplicationDB.Pacientes.FirstOrDefaultAsync(p => p.PacienteId == id) ?? throw new InvalidOperationException("Paciente Não encontrado!");
        }

        public async Task<IEnumerable<PacienteModel>> ObterTodosPacientes()
        {
            return await _ApplicationDB.Pacientes.ToListAsync();
        }
        public async Task<IEnumerable<PacienteModel>> ObterPacientesPorNome(string nome)
        {
           return await _ApplicationDB.Pacientes.Where(p => p.NomePaciente.Contains(nome)).ToListAsync();
        }

        public async Task<PacienteModel> ObterPacientePorConsulta(ConsultaModel consulta)
        {
             var paciente = await _ApplicationDB.Consultas
                .Where(c => c.ConsultaId == consulta.ConsultaId)
                .Select(p => p.Paciente)
                .FirstOrDefaultAsync();

            if (paciente == null)
                throw new InvalidOperationException("Paciente não encontrado!");

            return paciente;
        }
    }
}
