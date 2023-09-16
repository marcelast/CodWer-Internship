using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Entities
{
    public class Specialitate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int FacultateId { get; set; }
        [ForeignKey (nameof(FacultateId))]
        public Facultate Facultate { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
