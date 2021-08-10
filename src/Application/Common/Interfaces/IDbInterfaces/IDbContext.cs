using Microsoft.EntityFrameworkCore;
using System;

namespace Application.Common.Interfaces.IDbInterfaces
{
    public interface IDbContext : IDisposable
    {
        DbContext Instance { get; }
    }
}
