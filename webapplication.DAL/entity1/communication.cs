using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapplication.DAL.entity1
{
    public class Communications
    {
        public int Id { get; set; }
        [ForeignKey("student")]
        public int Idstudent { get; set; }

        [ForeignKey("lecture")]
        public int idlecture { get; set; }
        public string Day { get; set; }
        public string Date { get; set; }
        public string text { get; set; }
        public student student { get; set; }
        public lecture lecture { get; set; }
    }

}
