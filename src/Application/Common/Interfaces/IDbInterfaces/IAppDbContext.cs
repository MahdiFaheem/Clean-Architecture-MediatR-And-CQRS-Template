using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces.IDbInterfaces
{
    public interface IAppDbContext : IDbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
