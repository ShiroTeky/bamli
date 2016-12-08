using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopLost.Dapper
{
    public class CommentUtils
    {
        public Guid Id { get; set; }

        public string Post { get; set; }

        public DateTime? DatePost { get; set; }

        public string UserName { get; set; }

        public string ImageUrl { get; set; }

        public Guid AlertId { get; set; }

        public Guid MemberId { get; set; }
    }
}
