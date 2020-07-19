using Gestao_Salas_Back.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_Salas_Back.Data
{
    public class AgendamentoContext : DbContext
    {
    
        //Nome no plural para identificar que é uma lista
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Sala> Salas { get; set; }

        //Conexao com o banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=sasqlserver123;Persist Security Info=True;User ID=sa;Initial Catalog=GestaoSalas;Data Source=DESKTOP-0CNQA9F");
        }
    }
}
