using Unipsico.Data;
using Unipsico.Models;
using Microsoft.EntityFrameworkCore;

namespace Unipsico.Services
{
    public class EstagioServices
    {
        private readonly ApplicationDB _applicationDB;

        public EstagioServices(ApplicationDB applicationDB)
        {
            _applicationDB = applicationDB;
        }

        public async Task<IEnumerable<EstagioModel>> ObterTodosEstagios()
        {
            return await _applicationDB.Estagios
                .Include(e => e.InstituicaoCredenciada)
                .Include(e => e.Aluno)
                .ToListAsync();
        }

        public async Task<EstagioModel> ObterEstagioPorId(Guid id)
        {
             var estagio = await _applicationDB.Estagios
                .Include(e => e.InstituicaoCredenciada)
                .Include(e => e.Aluno)
                .FirstOrDefaultAsync(e => e.EstagioId == id);

            if (estagio == null)
            {
                throw new InvalidOperationException("Nenhum estágio encontrado!");
            }

            return estagio;
        }

        public async Task AdicionarEstagio(EstagioModel estagio)
        {
            _applicationDB.Estagios.Add(estagio);
            await _applicationDB.SaveChangesAsync();
        }

        public async Task AtualizarEstagio(EstagioModel estagio)
        {
            var estagioNoBancoDeDados = await _applicationDB.Estagios
                .FirstOrDefaultAsync(e => e.EstagioId == estagio.EstagioId);

            if (estagioNoBancoDeDados != null)
            {
                _applicationDB.Entry(estagioNoBancoDeDados).CurrentValues.SetValues(estagio);
                await _applicationDB.SaveChangesAsync();
            }
        }

        public async Task ExcluirEstagio(Guid id)
        {
            var estagio = await _applicationDB.Estagios.FindAsync(id);

            if (estagio != null)
            {
                _applicationDB.Estagios.Remove(estagio);
                await _applicationDB.SaveChangesAsync();
            }
        }
    }
}
