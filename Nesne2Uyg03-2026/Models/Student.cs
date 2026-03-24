using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne2Uyg03_2026.Models
{
    public class Student
    {
        public int Id { get; set; }


        [StringLength(20)]
        public string Number { get; set; }



        [StringLength(50)]
        public string Name { get; set; }


        [StringLength(50)]
        public string Email { get; set; }



        [StringLength(20)] 
        public string Phone { get; set; }


        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
