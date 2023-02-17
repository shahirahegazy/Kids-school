using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapplication.DAL.entity1
{
    public class course
    {
        public int Id { get; set; }
        [ForeignKey("lecture")]
        public int idlecture { get; set; }
        public string Name { get; set; }
        public double coast { get; set; }
        public List<student_cource> student_Cources { get; set; }
        public List<session> session { get; set; }
        public lecture lecture { get; set; }
    }
}
