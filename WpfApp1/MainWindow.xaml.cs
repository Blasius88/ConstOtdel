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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfApp1.Accessories;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Пример вывода фаила в textBlok
            TextBlock_Name_Fales.Text = "Фаил нe выбран";
        }

        /// <summary>
        /// Выбрать фаил Excel для началы работы создание отчетов и загрузки в бд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_Select_a_file(object sender, RoutedEventArgs e)
        {
            TextBlock_Name_Fales.Text = Convert.ToString(OpenFile.Open_File());
            DownloadFiles.DownLoadExelFile(TextBlock_Name_Fales.Text);
            if (list_accessories.Count != 0)
            {
                for (int i = 0; i <= list_accessories.Count; i++)
                {
                    ListOrder.ItemsSource = list_accessories;
                }
            }
        }

        /// <summary>
        /// Загрузить список фурнитуры в бд 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Download_accessories_list(object sender, RoutedEventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();
        }

        private void MenuItem_Click_download_order(object sender, RoutedEventArgs e)
        {

        }

        private void Add_accessories_list(object sender, RoutedEventArgs e)
        {

        }

        private void Hardware_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Hardware_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Dye_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Dye_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Veneer_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Veneer_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Aluminum_frame_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Aluminum_frame_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Glass_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Glass_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Tree_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Tree_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Soft_element_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Soft_element_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void compartment_doors_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void compartment_doors_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void metal_frame_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void metal_frame_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}