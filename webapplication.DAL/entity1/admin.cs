using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapplication.DAL.entity1
{
    public class admin
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
    }
}
