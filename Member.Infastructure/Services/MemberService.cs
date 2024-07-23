using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Member.Application.DTOs;
using Member.Application.Interfaces;
using Member.Infastructure.Data;
using Member.Core.Models;
namespace Member.Infastructure.Services
{
    public class MemberService : IMemberService
    {
        private readonly ApplicationDbContext _context;

        public MemberService(ApplicationDbContext context)
        {
            this._context = context;
        }
        public ResponseDTO AddMember(MemberDTO memberDTO)
        {
            MemberEntity member = new MemberEntity
            {
                Name = memberDTO.Name,
                Type = memberDTO.Type,
                Address = memberDTO.Address,
            };

            _context.Members.Add(member);
            int res = _context.SaveChanges();

            if (res == 1)
            {
                return new ResponseDTO
                {
                    Message = "خسنا بني تم الاضافه",
                    StatusCode = 200,
                    IsSuccess = true,
                    Model = memberDTO
                };
            }

            return new ResponseDTO
            {
                Message = "الاضافه لم تتم بني",
                StatusCode = 400,
                IsSuccess = false,
                Model = null
            };
        }

        public ResponseDTO DeleteMember(int Id)
        {
            MemberEntity? member = _context.Members.SingleOrDefault(m => m.Id == Id);

            if (member != null)
            {
                _context.Members.Remove(member);
                _context.SaveChanges();

                return new ResponseDTO
                {
                    StatusCode = 200,
                    Message = "تمام يا وحش",
                    IsSuccess = true,
                    Model = member
                };
            }

            return new ResponseDTO
            {
                StatusCode = 400,
                Message = "مفيش حد بالاي دي دا يحبيبي والكويري راجعه بنالل",
                IsSuccess = false,
                Model = null
            };
        }

        public ResponseDTO GetMember(int Id)
        {
            MemberEntity? member = _context.Members.SingleOrDefault(m => m.Id == Id);

            if (member != null)
            {
                return new ResponseDTO
                {
                    StatusCode = 200,
                    Message = "تمام يا وحش",
                    IsSuccess = true,
                    Model = member
                };
            }

            return new ResponseDTO
            {
                StatusCode = 400,
                Message = "مفيش حد بالاي دي دا يحبيبي والكويري راجعه بنالل",
                IsSuccess = false,
                Model = null
            };
        }

        public ResponseDTO GetMembers()
        {
            var members = _context.Members.ToList();

            return new ResponseDTO
            {
                StatusCode = 200,
                Message = "تمام يا وحش",
                IsSuccess = true,
                Model = members
            };
        }

        public ResponseDTO UpdateMember(int Id, MemberDTO memberDTO)
        {
            MemberEntity? member = _context.Members.SingleOrDefault(m => m.Id == Id);

            if (member != null)
            {
                member.Name = memberDTO.Name;
                member.Address = memberDTO.Address;
                member.Type = memberDTO.Type;

                _context.Members.Update(member);
                _context.SaveChanges();

                return new ResponseDTO
                {
                    StatusCode = 200,
                    Message = "تمام يا وحش",
                    IsSuccess = true,
                    Model = member
                };
            }

            return new ResponseDTO
            {
                StatusCode = 400,
                Message = "مفيش حد بالاي دي دا يحبيبي والكويري راجعه بنالل",
                IsSuccess = false,
                Model = null
            };
        }
    }
}
