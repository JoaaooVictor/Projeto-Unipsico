using Microsoft.EntityFrameworkCore;
using Unipsico.Data;
using Unipsico.Models;
using Unipsico.Services.Interfaces;

namespace Unipsico.Services
{
    public class ProfessorServices : IProfessorServices
    {
        private readonly ApplicationDB _applicationDB;

        public ProfessorServices(ApplicationDB applicationDB)
        {
            _applicationDB = applicationDB;
        }

        public async Task<IEnumerable<ProfessorModel>> ObterTodosProfessores()
        {
            return await _applicationDB.Professores.ToListAsync();
        }

        public async Task<ProfessorModel> ObterProfessorPorId(Guid id)
        {
            return await _applicationDB.Professores.FindAsync(id);
        }

        public async Task AdicionarProfessor(ProfessorModel professor)
        {
            if (await ProfessorExistente(professor.RpProfessor))
            {
                throw new Exception("Professor já existente!");
            }
            else
            {
                _applicationDB.Professores.Add(professor);
                await _applicationDB.SaveChangesAsync();
            }
        }

        public async Task AtualizarProfessor(ProfessorModel professor)
        {
            _applicationDB.Entry(professor).State = EntityState.Modified;
            await _applicationDB.SaveChangesAsync();
        }

        public async Task ExcluirProfessor(Guid id)
        {
            var professor = await _applicationDB.Professores.FindAsync(id);

            if (professor != null)
            {
                _applicationDB.Professores.Remove(professor);
                await _applicationDB.SaveChangesAsync();
            }
        }

        public async Task<bool> ProfessorExistente(string numeroMatricula)
        {
            return await _applicationDB.Professores.AnyAsync(p => p.RpProfessor == numeroMatricula);
        }
    }

}
