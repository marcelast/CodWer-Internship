using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int FacultateId { get; set; }
        [ForeignKey("FacultateId")]
        public Facultate Facultate { get; set; }
        [ForeignKey("SpecialitateId")]
        public int SpecialitateId { get; set; }
        public Specialitate Specialitate { get; set; }
        public int anStudiu { get; set; }
    }
}
