﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Hardware_Suppliers
    {

        /// <summary>
        /// Id фурнитуры 
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// id поcтавщика 
        /// </summary>
        public int Supplier_Name { get; set; }  // название поставщика 

        /// <summary>
        /// название фурнитуры 
        /// </summary>
        public string Hardware_Name { get; set; } // название фурнитуры

        /// <summary>
        /// дополнительное описание фурнитуры (комплектация, размеры и т.д.)
        /// </summary>
        public string Description { get; set; } 
        
        /// <summary>
        /// Цвет 
        /// </summary>
        public string Color { get; set; }
        
        /// <summary>
        /// Список фурнитуры 
        /// </summary>
        public static List<Hardware_Suppliers> list_hardware_s = new List<Hardware_Suppliers>();

    }
}
