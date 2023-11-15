namespace Unipsico.Models
{
    public class EnderecoModel
    {
        public Guid EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public virtual InstituicaoCredenciadaModel? InstituicaoCredenciada { get; set; }
    }
}
