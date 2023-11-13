using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfApp1
{
    /// <summary>
    /// класс фурнитуры от базис мебельщик 
    /// </summary>
   public class Accessories
    {
        /// <summary>
        /// id фурнитуры с базис мебельщика 
        /// </summary>
        public int ID { get; set; }

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
