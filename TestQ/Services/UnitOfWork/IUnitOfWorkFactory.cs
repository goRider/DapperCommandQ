using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestQ.Services.UnitOfWork
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create(bool transactional = false, IsolationLevel isolationLevel = IsolationLevel.ReadCommitted, RetryOptions retryOptions = null);
        Task<IUnitOfWork> CreateAsync(bool transactional = false, IsolationLevel isolationLevel = IsolationLevel.ReadCommitted, RetryOptions retryOptions = null, CancellationToken cancellationToken = default);
    }
}
