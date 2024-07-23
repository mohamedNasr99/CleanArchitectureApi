using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.DTOs
{
    public class ResponseDTO
    {
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public required string Message { get; set; } 
        public object? Model { get; set; }
    }
}
