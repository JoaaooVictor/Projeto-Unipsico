using Unipsico.Models;

namespace Unipsico.Services.Interfaces
{
    public interface IEnderecoServices
    {
        Task<IEnumerable<EnderecoModel>> ObterTodosEnderecos();
        Task<EnderecoModel> ObterEnderecoPorId(Guid id);
        Task AdicionarEndereco(EnderecoModel endereco);
        Task AtualizarEndereco(EnderecoModel endereco);
        Task ExcluirEndereco(Guid id);
    }
}
