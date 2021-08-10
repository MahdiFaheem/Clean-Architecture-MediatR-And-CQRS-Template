using Application.Common.DTOs.EntityDTOs;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CQRS.Commands.PersonCommands
{
    public class CreatePersonCommand : PersonDTO, IRequest<Person>
    {
        private class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, Person>
        {
            private readonly IPersonRepository _repo;
            private readonly IMapper _mapper;

            public CreatePersonCommandHandler(IPersonRepository repo, IMapper mapper)
            {
                _repo = repo;
                _mapper = mapper;
            }

            public async Task<Person> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
            {
                var person = _mapper.Map<Person>(request);
                await _repo.Add(person);

                return person;
            }
        }
    }
}
