using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TestQ.Services.UnitOfWork
{
    public interface IQuery<out T>
    {
        T Execute(IDbConnection connection, IDbTransaction transaction);
    }
}
