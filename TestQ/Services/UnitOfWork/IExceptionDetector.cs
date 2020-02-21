using System;
using System.Collections.Generic;
using System.Text;

namespace TestQ.Services.UnitOfWork
{
    public interface IExceptionDetector
    {
        bool ShouldRetryOn(Exception ex);
    }
}
