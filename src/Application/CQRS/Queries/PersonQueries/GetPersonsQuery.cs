using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CQRS.Queries.PersonQueries
{
    public class GetPersonsQuery : IRequest<ICollection<Person>>
    {
        public class GetPersonsQueryHandler : IRequestHandler<GetPersonsQuery, ICollection<Person>>
        {
            private readonly IPersonRepository _repo;
            private readonly IMapper _mapper;

            public GetPersonsQueryHandler(IPersonRepository repo, IMapper mapper)
            {
                _repo = repo;
                _mapper = mapper;
            }

            public async Task<ICollection<Person>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
            {
                return await _repo.GetAllAsync();
            }
        }
    }
}