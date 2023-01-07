using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
   public class Accessories
    {

        /// <summary>
        /// Наименование 
        /// </summary>
        public string Name { get; set; } // Наименоваеие 

        /// <summary>
        /// Количество 
        /// </summary>
        public string Quantity { get; set; } // Количество 

        /// <summary>
        /// Поставщик 
        /// </summary>
        public string Provider { get; set; } //поставщик 


        /// <summary>
        /// Список фурнитуры (формирование базис)
        /// </summary>
        public static List<Accessories> list_accessories = new List<Accessories>();
     }
}
