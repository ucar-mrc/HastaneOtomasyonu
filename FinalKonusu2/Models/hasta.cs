using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalKonusu2.Models
{
   public class hasta
    {
        [Key]
        public int hastaId { get; set; }
        public String hastaAdi { get; set; }
        public String hastaSoyAdi { get; set; }
        public int hastaYasi  { get; set; }
        public String gittigiBolum { get; set; }
    }
}
