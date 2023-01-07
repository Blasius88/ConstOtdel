using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WpfApp1
{
    class OpenFile
    {
        public static string Open_File()
        {
            string fileName = "";

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text documents (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                fileName = dialog.FileName;
            }
            return fileName;

        }
    }
}
