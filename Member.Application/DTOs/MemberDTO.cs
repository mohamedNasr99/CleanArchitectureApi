using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.DTOs
{
    public class MemberDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [AllowedValues("male", "female", "انثى", "ذكر")]
        public string Type { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
