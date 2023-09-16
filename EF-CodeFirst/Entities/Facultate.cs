using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Entities
{
    public class Facultate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decan { get; set; }
        public int nrStudents { get; set; }
        public ICollection<Specialitate> Specialitati { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
