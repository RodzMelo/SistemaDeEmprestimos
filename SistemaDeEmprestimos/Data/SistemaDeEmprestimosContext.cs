using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeEmprestimos.Models;

namespace SistemaDeEmprestimos.Data
{
    public class SistemaDeEmprestimosContext : DbContext
    {
        public SistemaDeEmprestimosContext (DbContextOptions<SistemaDeEmprestimosContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaDeEmprestimos.Models.Cliente> Cliente { get; set; }

        public DbSet<SistemaDeEmprestimos.Models.Emprestimo> Emprestimo { get; set; }

        public DbSet<SistemaDeEmprestimos.Models.Parcela> Parcela { get; set; }
    }
}
