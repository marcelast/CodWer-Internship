using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Entities
{
    public class Curs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int nrCredite { get; set; }
        public int SpecialitateId { get; set; }
        [ForeignKey (nameof(SpecialitateId))]
        public Specialitate Specialitate { get; set; }
        public int ProfesorId { get; set; }
        [ForeignKey(nameof(ProfesorId))]
        public Profesor Profesor { get; set; }
    }
}
