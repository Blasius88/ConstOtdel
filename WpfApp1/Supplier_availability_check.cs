using System;
using System.Collections.Generic;
using System.Linq;
using static WpfApp1.Suppliers_Hadware;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Supplier_availability_check
    {
        public static int Check(string name_supplier)
        {
            int a = -1;
            foreach (var s in list_suppliers_hardware)
            {
                if (s.Name == name_supplier)
                {
                    a = s.ID;
                }
            }
            return a;
        }
    }
}
