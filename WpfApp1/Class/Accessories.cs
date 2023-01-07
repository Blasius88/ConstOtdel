using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
   public class Accessories
    {
        public string Name { get; set; } // Наименоваеие 

        public string Quantity { get; set; } // Количество 

        public string Provider { get; set; } // провайдер 



        public static List<Accessories> list_accessories = new List<Accessories>();
     }
}
