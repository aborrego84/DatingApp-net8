using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]        
        public string username { get; set; } = string.Empty;
        [Required]
        [StringLength(8,MinimumLength =4)]
        public string password { get; set; } = string.Empty;
    }
}