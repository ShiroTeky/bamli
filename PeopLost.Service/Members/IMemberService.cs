
using PeopLost.Core.Domain.Pictures;
using PeopLost.Core.Domain.Members;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PeopLost.Service.Members
{
    public partial interface IMemberService
    {
        /// <summary>
        /// Deletes a  member
        /// </summary>
        /// <param name="Member">Member</param>
        void Delete(Member Member);

        /// <summary>
        /// Gets a member
        /// </summary>
        /// <param name="MemberId">The Member identifier</param>
        /// <returns>Member</returns>
        Member GetById(Guid MemberId);


        IList<Member> GetAll();

        /// <summary>
        /// Inserts a Member item
        /// </summary>
        /// <param name="news">Member</param>
        void Insert(Member Member);

        Member GetByEmail(string email);
        /// <summary>
        /// Updates the Member item
        /// </summary>
        /// <param name="Member">Member item</param>
        void Update(Member Member);
      
    }
}
