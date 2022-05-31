using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeEmprestimos.Models
{
    public class Parcela
    {
        [Display(Name ="ID parcela")]
        public int ParcelaId { get; set; }
        
        [Display(Name ="ID emprestimo")]
        public int EmprestimoId { get; set; }
        public Emprestimo Emprestimo { get; set; }
        
        [Display(Name ="Valor da parcela")]
        public double ValorParcela { get; set; }

        [Display(Name = "Numero da parcela")]
        public int NumeroParcela { get; set; }
        public DateTime DiaVencimento { get; set; }
        public bool Pago { get; set; }
    }
}
