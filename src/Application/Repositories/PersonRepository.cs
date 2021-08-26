using Application.Common.Interfaces.IDbInterfaces;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IPersonRepository : IBaseRepository<Person>
    {

    }

    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        private readonly IAppDbContext _context;

        public PersonRepository(IAppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
