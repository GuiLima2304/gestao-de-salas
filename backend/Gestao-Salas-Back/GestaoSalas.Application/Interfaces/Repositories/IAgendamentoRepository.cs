using EFCore.Dominio;
using EFCore.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GestaoSalas.Application.Interfaces.Repositories
{
    public interface IAgendamentoRepository : IRepository<Agendamento> 
    {
    }
}
