using Application.Common.DTOs.EntityDTOs;
using Application.Repositories;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CQRS.Commands.PersonCommands
{
    public class UpdatePersonCommand : PersonDTO, IRequest<int?>
    {
        public int Id { get; set; }
        public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand, int?>
        {
            private readonly IPersonRepository _repo;
            private readonly IMapper _mapper;

            public UpdatePersonCommandHandler(IPersonRepository repo, IMapper mapper)
            {
                _repo = repo;
                _mapper = mapper;
            }

            public async Task<int?> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
            {
                var person = await _repo.GetById(request.Id);

                if (person == null)
                {
                    return null;
                }

                person = _mapper.Map(request, person);

                return await _repo.Update(person);
            }
        }
    }
}
