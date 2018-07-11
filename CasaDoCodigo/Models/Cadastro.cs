using System.ComponentModel.DataAnnotations;

namespace CasaDoCodigo.Models{
    public class Cadastro : BaseModel
    {
        public Cadastro()
        {
        }

        public virtual Pedido Pedido { get; set; }
        [MinLength(5, ErrorMessage = "Nome deve ter no m�nimo 5 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve ter no m�ximo 50 caracteres")]
        [Required(ErrorMessage = "Nome � obrigat�rio")]
        public string Nome { get; set; } = "";
        [Required(ErrorMessage = "Email � obrigat�rio")]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Telefone � obrigat�rio")]
        public string Telefone { get; set; } = "";
        [Required(ErrorMessage = "Endereco � obrigat�rio")]
        public string Endereco { get; set; } = "";
        [Required(ErrorMessage = "Complemento � obrigat�rio")]
        public string Complemento { get; set; } = "";
        [Required(ErrorMessage = "Bairro � obrigat�rio")]
        public string Bairro { get; set; } = "";
        [Required(ErrorMessage = "Municipio � obrigat�rio")]
        public string Municipio { get; set; } = "";
        [Required(ErrorMessage = "UF � obrigat�rio")]
        public string UF { get; set; } = "";
        [Required(ErrorMessage = "CEP � obrigat�rio")]
        public string CEP { get; set; } = "";

        internal void Update(Cadastro novoCadastro)
        {
            this.Bairro = novoCadastro.Bairro;
            this.CEP = novoCadastro.CEP;
            this.Complemento = novoCadastro.Complemento;
            this.Email = novoCadastro.Email;
            this.Endereco = novoCadastro.Endereco;
            this.Municipio = novoCadastro.Municipio;
            this.Nome = novoCadastro.Nome;
            this.Telefone = novoCadastro.Telefone;
            this.UF = novoCadastro.UF;
        }
    }
}