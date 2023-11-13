using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Class;

namespace WpfApp1
{
    class DownloadHardwareBd
    {

        private static ConstrContext db;

        /// <summary>
        /// загрузка в бд фурнитуру 
        /// </summary>
        /// <returns></returns>
        private static bool DownloadHardwareBd_()
        {
            db = new ConstrContext();
            bool check = false;
            // нужен для контроля списка фурнитуры 
            int a = 0;

            // считываем со списка фурнитуру 
            for (int i = 0; i < Hardware.list_hardware.Count; i++)
            {
                Hardware newHardware = new Hardware
                {
                    ID = Convert.ToInt32(Hardware.list_hardware [i].ID),
                    ID_Supplier_Name = Convert.ToInt32(Hardware.list_hardware[i].ID_Supplier_Name),
                    Hardware_Name = Hardware.list_hardware[i].Hardware_Name,
                    Supplier_Name =Hardware.list_hardware[i].Supplier_Name,
                    Color = Hardware.list_hardware[i].Color,
                    Description = Hardware.list_hardware[i].Description,
                };

                //добавляем новую фурнитуру в класс 
                db.Hardwares.Add(newHardware);
                //сохраняем в бд 
                db.SaveChanges();

                a++;
            }
            db.Dispose();

            // проверям что  производилась запесь в бд  
            if (a > 0)
                check = true;
            else
                check = false;
            // после добавления очищаем список фурнитуры 
            Hardware.list_hardware.Clear();

            return check;
        }



        public void CheckDownloadHardware()
        {
            try
            {
                bool check = false;
                
                //добавление фурнитуры в базу данных  
                check = DownloadHardwareBd_();
                if (check)
                {
                    MessageBox.Show("Запись в бд прошла успешно");
                }
                else
                {
                    MessageBox.Show("Ошибка записи в бд ");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
