﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestQ.Services.UnitOfWork
{
    public interface ICommand
    {
        bool RequiresTransaction { get; }
        void Execute(IDbConnection connection, IDbTransaction transaction);
    }

    public interface ICommand<out T>
    {
        bool RequiresTransaction { get; }
        T Execute(IDbConnection connection, IDbTransaction transaction);
    }

    public interface IAsyncCommand
    {
        bool RequiresTransaction { get; }
        Task ExecuteAsync(IDbConnection connection, IDbTransaction transaction, CancellationToken cancellationToken = default);
    }

    public interface IAsyncCommand<T>
    {
        bool RequiresTransaction { get; }
        Task<T> ExecuteAsync(IDbConnection connect, IDbTransaction transaction, CancellationToken cancellationToken = default);
    }
}
