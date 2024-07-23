using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Core.Models
{
    public class MemberEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [AllowedValues("male", "female", "انثى", "ذكر")]
        [Required]
        public required string Type { get; set; }
        [Required]
        public required string Address { get; set; }
    }
}
