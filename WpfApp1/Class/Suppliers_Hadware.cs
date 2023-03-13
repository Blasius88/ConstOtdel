using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    /// <summary>
    /// Поставщик 
    /// </summary>
    public class Suppliers_Hadware
    {
        /// <summary>
        /// Id поставщика 
        /// </summary>
        public int ID { get; set ; }

        /// <summary>
        /// Название постовщика 
        /// </summary>
        public string Name { get; set; }
 
        //public Suppliers_Hadware(int ID, string Name)
        //{
        //    this.ID = ID;
        //    this.Name = Name;
        //}

        /// <summary>
        /// Список поставщиков 
        /// </summary>
        public static List<Suppliers_Hadware> list_suppliers_hardware = new List<Suppliers_Hadware>();
    }
}
