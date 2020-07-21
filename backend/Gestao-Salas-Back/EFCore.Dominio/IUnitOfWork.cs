using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Dominio
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}
