using Microsoft.EntityFrameworkCore;
using Unipsico.Data;
using Unipsico.Models;
using Unipsico.Services.Interfaces;

namespace Unipsico.Services
{
    public class ConsultaServices : IConsultaService
    {
        private readonly ApplicationDB _ApplicationDB;

        public ConsultaServices(ApplicationDB applicationDB)
        {
            _ApplicationDB = applicationDB;
        }

        public async Task<IEnumerable<ConsultaModel>> ObterTodasConsultas()
        {
            return await _ApplicationDB.Consultas.ToListAsync();
        }

        public async Task<ConsultaModel> ObterConsultaPorId(Guid id)
        {
            return await _ApplicationDB.Consultas.FirstOrDefaultAsync(c => c.ConsultaId == id);
        }

        public async Task AdicionarConsulta(ConsultaModel consulta)
        {
            _ApplicationDB.Consultas.Add(consulta);
            await _ApplicationDB.SaveChangesAsync();
        }

        public async Task AtualizarConsulta(ConsultaModel consulta)
        {
            var consultaNoBancoDeDados = await _ApplicationDB.Consultas.FindAsync(consulta.ConsultaId);

            if (consultaNoBancoDeDados != null)
            {
                _ApplicationDB.Entry(consultaNoBancoDeDados).CurrentValues.SetValues(consulta);
                await _ApplicationDB.SaveChangesAsync();
            }
        }

        public async Task ExcluirConsulta(Guid id)
        {
            var consulta = await _ApplicationDB.Consultas.FindAsync(id);

            if (consulta != null)
            {
                _ApplicationDB.Consultas.Remove(consulta);
                await _ApplicationDB.SaveChangesAsync();
            }
        }
    }
}
