using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static WpfApp1.Hardware;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Suppliers.xaml
    /// </summary>
    public partial class Suppliers : Window
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        /// <summary>
        /// открывает новое окно и добавляет 1 элемент наименования фурнитуры 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_1_item_of_hardware_name(object sender, RoutedEventArgs e)
        {
            AddOneSuppliers addOneSuppliers = new AddOneSuppliers();
            addOneSuppliers.Show();
        }

        /// <summary>
        /// Добавления списка фурнитуры в бд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Download_list_suppliers(object sender, RoutedEventArgs e)
        {
            DownloadFiles.Downloud_Hardware_Suppliers(Convert.ToString(OpenFile.Open_File()));
            if (list_hardware.Count != 0)
            {
                for (int i = 0; i <= list_hardware.Count; i++)
                {
                    ListOrder.ItemsSource = list_hardware;
                }
            }

        }
       
        /// <summary>
        /// Обновить список фурнитуры 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_hardware_list(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// Нажатие клавиши Ок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ok(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// Нажатие клавиши назад 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Редактировать карточку фурнитуры 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_Edit(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// Удалить карточку фурнитуры 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Button(object sender, RoutedEventArgs e)
        {

        }

    }
}
