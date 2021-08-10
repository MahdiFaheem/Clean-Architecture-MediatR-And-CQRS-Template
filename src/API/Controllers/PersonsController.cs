
using Application.Common.DTOs.EntityDTOs;
using Application.CQRS.Commands.PersonCommands;
using Application.CQRS.Queries.PersonQueries;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class PersonsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<PersonDTO>>> Get()
        {
            return Ok(await Mediator.Send(new GetPersonsQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDTO>> GetById(int id)
        {
            var result = await Mediator.Send(new GetPersonByIdQuery { Id = id });
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<PersonDTO>> Post([FromBody] CreatePersonCommand command)
        {
            var result = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, UpdatePersonCommand command)
        {
            command.Id = id;
            var result = await Mediator.Send(command);

            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await Mediator.Send(new DeletePersonCommand { Id = id });

            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
