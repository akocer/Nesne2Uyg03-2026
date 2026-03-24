using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne2Uyg03_2026.Models
{
    public class Lesson
    {
        public int Id { get; set; }



        [StringLength(10)]
        public string Code { get; set; }



        [StringLength(50)]
        public string Name { get; set; }



        public int Credit { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
