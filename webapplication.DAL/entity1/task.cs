using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapplication.DAL.entity1
{
    public class tasks

    {
        public int Id { get; set; }
        public string title { get; set; }
        public string linkform { get; set; }

        [ForeignKey("student")]
        public int Idstudent { get; set; }
        [ForeignKey("lecture")]
        public int Idlecture { get; set; }
        public student student { get; set; }

        public lecture lecture { get; set; }
    }
}
