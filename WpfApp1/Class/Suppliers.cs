using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Class
{
    public class Suppliers
    {
        /// <summary>
        /// Id поставщика 
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Название постовщика 
        /// </summary>
        public string Name_Suppler { get; set; }


        /// <summary>
        /// Список поставщиков 
        /// </summary>
        public static List<Suppliers> suppliers = new List<Suppliers>();
    }
}
