using Application.Common.DTOs.ErrorDTOs;
using System.Collections.Generic;

namespace Application.Common.DTOs.ResponseDTOs
{
    public class ErrorResponseDTO
    {
        public List<ValidationErrorDTO> Errors { get; set; } = new List<ValidationErrorDTO>();
    }
}
