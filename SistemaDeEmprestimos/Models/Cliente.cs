using System.ComponentModel.DataAnnotations;

namespace SistemaDeEmprestimos.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Nome cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        public string CPF { get; set; }

        [EmailAddress(ErrorMessage = " O campo deve ser um email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Renda mensal")]
        public string RendaMensal { get; set; }

        [Display(Name = "Status do cliente")]
        public string StatusEmprestimo { get; set; }
    }
}
