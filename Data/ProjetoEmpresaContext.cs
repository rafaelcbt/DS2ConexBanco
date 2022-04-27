using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoEmpresa.Models;

    public class ProjetoEmpresaContext : DbContext
    {
        public ProjetoEmpresaContext (DbContextOptions<ProjetoEmpresaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoEmpresa.Models.Funcionario> Funcionario { get; set; }
    }
