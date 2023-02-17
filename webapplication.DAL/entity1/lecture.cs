using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace webapplication.DAL.entity1
{
    public class lecture
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int birthday { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string photo { get; set; }
        public string description { get; set; }
        public string gender { get; set; }
        public List<lectuerstudent> lectuerstudent { get; set; }
        public List<session> session { get; set; }

        public List<course> course { get; set; }
        public List<tasks> tasks { get; set; }
        public List<Communications> Communications { get; set; }


    }
}
