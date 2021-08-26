using Application.Repositories;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CQRS.Queries.PersonQueries
{
    public class GetPersonByIdQuery : IRequest<Person>
    {
        public int Id { get; set; }

        public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, Person>
        {
            private readonly IPersonRepository _repo;

            public GetPersonByIdQueryHandler(IPersonRepository repo)
            {
                _repo = repo;
            }

            public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
            {
                return await _repo.GetByIdAsync(request.Id);
            }
        }
    }
}
