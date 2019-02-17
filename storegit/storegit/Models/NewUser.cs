using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storegit.Models
{
    public class NewUser
    {
        public int id { get; set; }
        public string name { get; set; }
        public int phone { get; set; }
        public string email { get; set; }

        //public ICollection<orders> Orders { get; set; }

    }
}
