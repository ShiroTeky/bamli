using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopLost.Core.Domain.ConnectionHub
{
    public class Connections:BaseEntity
    {
        public string UserAgent { get; set; }
        public bool Connected { get; set; }
        public Guid MemberId { get; set; }
    }
}
