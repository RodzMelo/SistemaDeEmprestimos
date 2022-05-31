using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeEmprestimos.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        
        [Display(Name = "Nome do cliente")]
        public int ClienteId { get; set; }
        
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Valor solicitado")]
        public decimal ValorEmprestimo { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Nº de parcelas")]
        public int QuantidadeParcelas { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Porcentagem dos juros")]
        public decimal ValorJuros { get; set; }
        
        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Valor total")]
        public decimal ValorTotal { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Valor da parcela")]
        public decimal ValorParcela { get; set; }

        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Dia do vencimento")]
        public int DiaVencimento { get; set; }

        [Display(Name = "Nº de parcelas pagas")]
        public int QuantidadeParcelasPagas { get; set; }

        [Display(Name = "Valor pago")]
        public decimal ValorPago { get; set; }
        
        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Data da solicitação")]
        public DateTime DataEmprestimo { get; set; }
        
        [Required(ErrorMessage = " O campo é obrigatório")]
        [Display(Name = "Data quitação")]
        public DateTime DataDevolucao { get; set; }
        
        [Display(Name = "Quitado")]
        public bool Devolvido { get; set; }
    }
}
