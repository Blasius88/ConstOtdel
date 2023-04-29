using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using static WpfApp1.Suppliers_Hadware;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddOneSuppliers.xaml
    /// </summary>
    public partial class AddOneSuppliers : Window
    {
        public AddOneSuppliers()
        {
            InitializeComponent();
            //    the_suppler.ItemsSource = Suppliers_Hadware.list_suppliers_hardware.ToArray(Name);
        }

        /// <summary>
        /// Добавить еденицу фурнитуры 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                foreach (var s in Hardware.list_hardware)
                {
                    str = s.Supplier_Name.ToString();
                }
            }
            File.WriteAllText(saveFileDialog.FileName, str);
        }

        /// <summary>
        /// закрыть окно 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void the_suppler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            MessageBox.Show(selectedItem.Content.ToString());
        }

        private bool conformity_check(string i)
        {
            bool check = true;

            return check;
        }
    }
}
