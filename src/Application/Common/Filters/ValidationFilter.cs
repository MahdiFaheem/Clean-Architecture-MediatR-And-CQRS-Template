using Application.Common.DTOs.ErrorDTOs;
using Application.Common.DTOs.ResponseDTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Common.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errorsInModelState = context.ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(x => x.ErrorMessage)).ToArray();

                var errorResponseDTO = new ErrorResponseDTO();

                foreach (var error in errorsInModelState)
                {
                    foreach (var subError in error.Value)
                    {
                        var errorDetailsDTO = new ValidationErrorDTO
                        {
                            FieldName = error.Key,
                            Message = subError
                        };

                        errorResponseDTO.Errors.Add(errorDetailsDTO);
                    }
                }

                context.Result = new BadRequestObjectResult(errorResponseDTO);
            }

            await next();
        }
    }
}
