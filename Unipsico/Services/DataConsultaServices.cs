using Microsoft.EntityFrameworkCore;
using Unipsico.Data;
using Unipsico.Models;
using Unipsico.Models.Enums.Consultas;
using Unipsico.Services.Interfaces;

namespace Unipsico.Services
{
    public class DataConsultaServices : IDataConsultaServices
    {
        private readonly ApplicationDB _applicationDB;

        public DataConsultaServices(ApplicationDB applicationDB)
        {
            _applicationDB = applicationDB;
        }

        public async Task<IEnumerable<DataConsultaModel>> ObterDatasDisponiveis()
        {
            return await _applicationDB.DatasConsultas.Where(dc => dc.StatusConsulta == StatusConsulta.Disponivel).ToListAsync();
        }

        public async Task<IEnumerable<DataConsultaModel>> ObterDatasCanceladas()
        {
            return await _applicationDB.DatasConsultas.Where(dc => dc.StatusConsulta == StatusConsulta.Cancelada).ToListAsync();
        }

        public async Task<IEnumerable<DataConsultaModel>> ObterDatasAgendadas()
        {
            return await _applicationDB.DatasConsultas.Where(dc => dc.StatusConsulta == StatusConsulta.Agendada).ToListAsync();
        }
        public async Task<IEnumerable<DataConsultaModel>> ObterDatasRealizadas()
        {
            return await _applicationDB.DatasConsultas.Where(dc => dc.StatusConsulta == StatusConsulta.Realizada).ToListAsync();
        }

        public async Task<IEnumerable<DataConsultaModel>> ObterDatasRemarcadas()
        {
            return await _applicationDB.DatasConsultas.Where(dc => dc.StatusConsulta == StatusConsulta.Remarcada).ToListAsync();
        }

        public async Task AdicionarDataConsulta(DataConsultaModel dataConsulta)
        {
            _applicationDB.DatasConsultas.Add(dataConsulta);
            await _applicationDB.SaveChangesAsync();
        }

        public async Task AtualizarDataConsulta(DataConsultaModel dataConsulta)
        {
            var dataConsultaNoBancoDeDados = await _applicationDB.DatasConsultas.FindAsync(dataConsulta.DataConsultaId);

            if (dataConsultaNoBancoDeDados != null)
            {
                _applicationDB.Entry(dataConsultaNoBancoDeDados).CurrentValues.SetValues(dataConsulta);
                await _applicationDB.SaveChangesAsync();
            }
        }

        public async Task ExcluirDataConsulta(Guid id)
        {
            var dataConsulta = await _applicationDB.DatasConsultas.FindAsync(id);

            if (dataConsulta != null)
            {
                _applicationDB.DatasConsultas.Remove(dataConsulta);
                await _applicationDB.SaveChangesAsync();
            }
        }

    }
}
