using Application.Repositories;
using AutoMapper;
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
            private readonly IMapper _mapper;

            public GetPersonByIdQueryHandler(IPersonRepository repo, IMapper mapper)
            {
                _repo = repo;
                _mapper = mapper;
            }

            public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
            {
                return await _repo.GetByIdAsync(request.Id);
            }
        }
    }
}
