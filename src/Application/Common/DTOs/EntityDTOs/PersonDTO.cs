using Domain.Enums;
using System;

namespace Application.Common.DTOs.EntityDTOs
{
    public class PersonDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
