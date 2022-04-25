using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SistemaDP.Data
{

    public class SistemaDPContext : IdentityDbContext<IdentityUser>
    {
        public SistemaDPContext(DbContextOptions<SistemaDPContext> options)
            : base(options)
        {

        }

        public DbSet<SistemaDP.Models.Bancos> Bancos { get; set; }

        public DbSet<SistemaDP.Models.Funcionario> Funcionario { get; set; }

        public DbSet<SistemaDP.Models.Eventos> Eventos { get; set; }

        public DbSet<SistemaDP.Models.Admissao> Admissao { get; set; }

        public DbSet<SistemaDP.Models.Cargos> Cargos { get; set; }

        public DbSet<SistemaDP.Models.Divisao> Divisao { get; set; }

        public DbSet<SistemaDP.Models.EnderecoFuncionario> EnderecoFuncionario { get; set; }

        public DbSet<SistemaDP.Models.EnderecoLojas> EnderecoLojas { get; set; }

        public DbSet<SistemaDP.Models.EstadoCivil> EstadoCivil { get; set; }

        public DbSet<SistemaDP.Models.Familiares> Familiares { get; set; }

        public DbSet<SistemaDP.Models.HistoricoFerias> HistoricoFerias { get; set; }

        public DbSet<SistemaDP.Models.HistoricoFuncionario> HistoricoFuncionario { get; set; }

        public DbSet<SistemaDP.Models.HistoricoSalario> HistoricoSalario { get; set; }

        public DbSet<SistemaDP.Models.HorariosAtuais> HorariosAtuais { get; set; }

        public DbSet<SistemaDP.Models.HorariosOriginais> HorariosOriginais { get; set; }

        public DbSet<SistemaDP.Models.Instrucao> Instrucao { get; set; }

        public DbSet<SistemaDP.Models.Lojas> Lojas { get; set; }

        public DbSet<SistemaDP.Models.MotivosAfastamento> MotivosAfastamento { get; set; }

        public DbSet<SistemaDP.Models.PlanoDeSaude> PlanoDeSaude { get; set; }

        public DbSet<SistemaDP.Models.Salarios> Salarios { get; set; }

        public DbSet<SistemaDP.Models.TarifasDeOnibus> TarifasDeOnibus { get; set; }

        public DbSet<SistemaDP.Models.UnidadeDeFederacao> UnidadeDeFederacao { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}