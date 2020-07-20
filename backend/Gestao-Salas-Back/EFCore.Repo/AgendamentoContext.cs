using EFCore.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Repo
{
    public class AgendamentoContext : DbContext
    {
        //Referencia
        public AgendamentoContext(DbContextOptions<AgendamentoContext> options) : base(options) {}
    
        //Nome no plural para identificar que é uma lista
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Sala> Salas { get; set; }

        //Conexao com o banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
