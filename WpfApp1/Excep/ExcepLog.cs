using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace WpfApp1
{
    class ExcepLog
    {
        public static void Excep(Exception exception)
        {
            string path = @"\программирование\WPF\Program Files\ComstrOtdelWPF\WpfApp1\WpfApp1\Excep\ExepLog.txt";
            int count = File.ReadAllLines(path).Length;
            StreamWriter NewFile = new StreamWriter(path, true);
            try
            {
                NewFile.WriteLine(
                    $"{count}| " +
                    $"{exception}| " +
                    $"{DateTime.Now}| ");
                NewFile.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                NewFile.Close();
            }

        }
    }
}
