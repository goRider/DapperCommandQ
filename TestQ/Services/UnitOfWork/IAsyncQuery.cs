using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestQ.Services.UnitOfWork
{
    public interface IAsyncQuery<T>
    {
        Task<T> ExecuteAsync(IDbConnection connection, IDbTransaction transaction, CancellationToken cancellationToken = default);
    }
}
