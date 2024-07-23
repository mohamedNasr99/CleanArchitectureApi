using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Member.Application.Interfaces;
using Member.Application.DTOs;

namespace Member.Api.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _service;

        public MemberController(IMemberService service)
        {
            this._service = service;
        }

        [HttpGet("{Id}")]
        public IActionResult Member(int Id)
        {
            var res = _service.GetMember(Id);
            return StatusCode(res.StatusCode, res);
        }

        [HttpGet("[action]")]
        public IActionResult Members() 
        { 
            var res = _service.GetMembers();
            return StatusCode(res.StatusCode, res);
        }

        [HttpPost("[action]")]
        public IActionResult Add([FromQuery] MemberDTO memberDTO)
        {
            var res = _service.AddMember(memberDTO);
            return StatusCode(res.StatusCode, res);
        }

        [HttpPut("[action]")]
        public IActionResult Put(int Id, [FromQuery] MemberDTO memberDTO) 
        { 
            var res = _service.UpdateMember(Id, memberDTO);
            return StatusCode(res.StatusCode, res);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id) 
        {
            var res = _service.DeleteMember(Id);
            return StatusCode(res.StatusCode, res);
        }
    }
}
