using Microsoft.EntityFrameworkCore;
using Unipsico.Data;
using Unipsico.Models;
using Unipsico.Services.Interfaces;

namespace Unipsico.Services
{
    public class EnderecoService : IEnderecoServices
    {
        private readonly ApplicationDB _applicationDB;

        public EnderecoService(ApplicationDB applicationDB)
        {
            _applicationDB = applicationDB;
        }

        public async Task<IEnumerable<EnderecoModel>> ObterTodosEnderecos()
        {
            return await _applicationDB.Enderecos.ToListAsync();
        }

        public async Task<EnderecoModel> ObterEnderecoPorId(Guid id)
        {
            return await _applicationDB.Enderecos.FindAsync(id);
        }

        public async Task AdicionarEndereco(EnderecoModel endereco)
        {
            _applicationDB.Enderecos.Add(endereco);
            await _applicationDB.SaveChangesAsync();
        }

        public async Task AtualizarEndereco(EnderecoModel endereco)
        {
            _applicationDB.Entry(endereco).State = EntityState.Modified;
            await _applicationDB.SaveChangesAsync();
        }

        public async Task ExcluirEndereco(Guid id)
        {
            var endereco = await _applicationDB.Enderecos.FindAsync(id);

            if (endereco != null)
            {
                _applicationDB.Enderecos.Remove(endereco);
                await _applicationDB.SaveChangesAsync();
            }
        }
    }

}
