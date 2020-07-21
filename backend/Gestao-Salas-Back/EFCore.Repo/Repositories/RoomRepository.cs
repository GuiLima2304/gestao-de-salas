using EFCore.Dominio.Entities;
using GestaoSalas.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Repo.Repositories
{
    public class RoomRepository : RepositoryBase<Sala>, IRoomRepository
    {
        public RoomRepository(AgendamentoContext context) : base(context)
        {
        }
    }
}
