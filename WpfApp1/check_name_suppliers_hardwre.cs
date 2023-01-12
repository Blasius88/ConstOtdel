using System;
using System.Collections.Generic;
using static WpfApp1.Suppliers_Hadware;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class check_name_suppliers_hardwre
    {
        /// <summary>
        /// проверяем наличие поставщиков в списке (для избежания повторов)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool Check(string name)
        {
            bool check = true;
            foreach (var s in list_suppliers_hardware)
            {
                if (s.Name == name)
                {
                    check = false;
                }
            }
            return check;
        }

    }
}
