using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalKonusu2.Models
{
   public class Doktor
    {
        [Key]

        public int doktorId { get; set; }
        public String doktorAdi { get; set; }
        public String doktorSoyadi { get; set; }
        public int doktorYasi { get; set; }
        public String uzmanlik{ get; set; }



    }
}
