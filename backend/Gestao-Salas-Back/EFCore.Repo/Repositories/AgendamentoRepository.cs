using EFCore.Dominio;
using EFCore.Dominio.Entities;
using GestaoSalas.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCore.Repo.Repositories
{
    public class AgendamentoRepository : RepositoryBase<Agendamento>, IAgendamentoRepository
    {
        public AgendamentoRepository(AgendamentoContext context): base(context) { }

        public override IEnumerable<Agendamento> Get() 
        {
            return _context.Set<Agendamento>().Include(p => p.Sala).ToList();
        }
    }
}
