using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapplication.DAL.entity1
{
    public class lectuerstudent
    {
        [ForeignKey("lecture")]
        public int idlectuer { get; set; }
        public lecture lecture { get; set; }
        [ForeignKey("student")]
        public int idstudent { get; set; }

        public student student { get; set; }
    }
}
