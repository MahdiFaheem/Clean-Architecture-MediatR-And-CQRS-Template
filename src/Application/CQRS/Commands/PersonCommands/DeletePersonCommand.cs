using Application.Repositories;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CQRS.Commands.PersonCommands
{
    public class DeletePersonCommand : IRequest<int?>
    {
        public int Id { get; set; }
        public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand, int?>
        {
            private readonly IPersonRepository _repo;
            private readonly IMapper _mapper;

            public DeletePersonCommandHandler(IPersonRepository repo, IMapper mapper)
            {
                _repo = repo;
                _mapper = mapper;
            }
            public async Task<int?> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
            {
                var result = await _repo.GetByIdAsync(request.Id);

                if (result == null)
                {
                    return null;
                }

                return await _repo.RemoveAsync(result);
            }
        }
    }
}
