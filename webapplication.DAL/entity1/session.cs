using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapplication.DAL.entity1
{
    public class session
    {
        public int Id { get; set; }
        [ForeignKey("course")]
        public int idcourse { get; set; }
        [ForeignKey("lecture")]
        public int idlecture { get; set; } = 0;
        public string linkviedo { get; set; }
        public int sessiontime { get; set; }
        public course course { get; set; }
        public lecture lecture { get; set; }
    }
}
