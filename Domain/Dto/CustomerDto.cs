using System.ComponentModel.DataAnnotations;

namespace Domain.Dto
{
    public class CustomerDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set;}
    }
}