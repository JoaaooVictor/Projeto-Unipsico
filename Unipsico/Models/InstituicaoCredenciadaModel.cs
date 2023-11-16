namespace Unipsico.Models
{
    public class InstituicaoCredenciadaModel
    {
        public Guid InstituicaoCredenciadaId { get; set; }
        public string NomeInstituicao { get; set; }
        public Guid EnderecoId { get; set; }
        public virtual EnderecoModel Endereco { get; set; }
        public virtual ICollection<EstagioModel> Estagios { get; set; }
    }
}
