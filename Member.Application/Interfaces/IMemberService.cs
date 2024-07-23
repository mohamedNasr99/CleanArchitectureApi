using Member.Application.DTOs;
using Member.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.Interfaces
{
    public interface IMemberService
    {
        ResponseDTO AddMember(MemberDTO memberDTO);
        ResponseDTO DeleteMember(int Id);
        ResponseDTO UpdateMember(int Id, MemberDTO memberDTO);
        ResponseDTO GetMember(int Id);
        ResponseDTO GetMembers();
    }
}
