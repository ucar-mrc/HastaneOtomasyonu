using FinalKonusu2.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace FinalKonusu2.Context
{
    public class hastaneDBContext : DbContext
    {
        
        public hastaneDBContext()
            : base("name=hastaneDBContext")
        {
        }

        
         public virtual DbSet<hasta> Hastalar { get; set; }
         public virtual DbSet<Doktor> Doktorlar { get; set; }
    }

    
}