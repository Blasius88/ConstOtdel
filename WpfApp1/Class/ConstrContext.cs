using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace WpfApp1.Class
{
    class ConstrContext : DbContext
    {

        public ConstrContext() : base("DefaultConnection")
        { 
        
        }

        public DbSet<Accessories> Accessoriess { get; set; }

        public DbSet<Hardware> Hardwares { get; set; }

        public DbSet<Suppliers_Hadware> Suppliers_Hadwares { get; set; }
    }
}
