using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopLost.Dapper
{
    public class AlertUtils
    {
        public Guid AlertId { get; set; }
        public string Post { get; set; }
        public Guid PersonId { get;set;}
        public DateTime DateAlert { get; set; }
        public DateTime DayDisappear { get; set; }

        public string UserName { get; set; }
        public string ImageUrlMember { get; set; }
        public string Phone { get; set; }

        public string FirstName { get; set; }

   
        public string LastName { get; set; }

   
        public string Gender { get; set; }

        public string LooserAddress { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public int YearsOld { get; set; }

        public bool Found { get; set; }

        public string Caracteristics { get; set; }

        public string ImageUrlPerson { get; set; }

    }
}
