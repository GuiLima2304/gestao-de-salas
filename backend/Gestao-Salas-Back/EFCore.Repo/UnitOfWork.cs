using EFCore.Dominio;
using EFCore.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AgendamentoContext _context;

        public UnitOfWork(AgendamentoContext context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
