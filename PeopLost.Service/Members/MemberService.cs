
using System;
using System.Collections.Generic;
using System.Linq;
using PeopLost.Core.Data;
using PeopLost.Core.Domain.Members;
using PeopLost.Core.Domain.Pictures;
using PeopLost.Dapper.Members;

namespace PeopLost.Service.Members
{
    public class MemberService: IMemberService
    {
        IRepository<Member> memberRepository;
        MemberRepository memberdapper = new MemberRepository();
        //IRepository<Picture> pictureRepository;

        public MemberService(IRepository<Member> memberRepository)
            // IRepository<Picture> pictureRepository)
        {
            this.memberRepository = memberRepository;
           // this.pictureRepository = pictureRepository;
        }

        public virtual void Delete(Member member)
        {
            memberRepository.Delete(member);
            //pictureRepository.Delete(member.Picture);
        }

        public Member GetByEmail(string email)
        {
           return memberdapper.GetByEmail(email);
        }

        public virtual Member GetById(Guid memberId)
        {
            return memberdapper.FindById(memberId);
        }

        public virtual IList<Member> GetAll()
        {
            return memberdapper.GetAll().ToList();
        }

        public void Insert(Member member)
        {
            memberRepository.Insert(member);
       
        }

        public virtual void Update(Member member)
        {
            memberRepository.Update(member);
        }
    }
}
