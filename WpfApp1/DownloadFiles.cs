using System;
using static WpfApp1.Accessories;
using static WpfApp1.Hardware_Suppliers;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows;
using Microsoft.Office.Interop.Excel;

namespace WpfApp1
{
    public class DownloadFiles
    {
        private static Excel.Application excelApp;
        private static Workbook workBook;
        private static Worksheet workSheet;
        private static Excel.Range range;

        /// <summary>
        /// загрузка фаила с фурнитурой из заказа
        /// </summary>
        /// <param name="ExcelFilePath"></param>
        public static void DownLoadExelFile(string ExcelFilePath)
        {
            bool find = false;

            try
            {
                //открывоет книгу excel 
                excelApp = new Excel.Application();
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
                range = workSheet.UsedRange;
                for (int cCnt = 1; cCnt <= range.Rows.Count; cCnt++)
                {
                    if (Convert.ToString(workSheet.Cells[cCnt, 1].Value) == "Спецификация на фурнитуру, покупные изделия")
                    {
                        for (int cCnt1 = cCnt + 2; cCnt1 <= range.Rows.Count; cCnt1++)
                        {
                            if (Convert.ToString(workSheet.Cells[cCnt1, 2].Value) != "")
                            {
                                Accessories accessories = new Accessories
                                {
                                    Name = Convert.ToString(workSheet.Cells[cCnt1, 2].Value),
                                    Quantity = Convert.ToString(workSheet.Cells[cCnt1, 3].Value),
                                };
                                list_accessories.Add(accessories);
                            }
                        }
                        find = true;
                    }
                }
                if (!find)
                    MessageBox.Show("not found");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                ExcepLog.Excep(exp);
            }
            finally
            {
                workBook.Close();
                excelApp.Quit();
            }
        }

        /// <summary>
        /// Загрузка файла с фурнитурой и поставщиками  
        /// </summary>
        /// <param name="excel_file_path"></param> 
        public static void Downloud_Hardware_Suppliers(string excel_file_path)
        {
            int a = 0;
            bool find = false;
            try
            {
                excelApp = new Excel.Application();
                workBook = excelApp.Workbooks.Open(excel_file_path);
                workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
                range = workSheet.UsedRange;
                for (int cCnt = 1; cCnt <= range.Rows.Count; cCnt++)
                {
                    if (Convert.ToString(workSheet.Cells[cCnt, 1].Value) != "" || Convert.ToString(workSheet.Cells[cCnt, 1].Value) != null)
                    {
                        Hardware_Suppliers suppliers = new Hardware_Suppliers
                        {
                            Supplier_Name = Convert.ToString(workSheet.Cells[cCnt, 1].Value),
                            Hardware_Name = Convert.ToString(workSheet.Cells[cCnt, 2].Value),
                        };
                        if (Convert.ToString(suppliers.Hardware_Name) != null)
                        { 
                            list_hardware_s.Add(suppliers);
                            a++;
                        }
                    }
                    find = true;
                }
                if (!find)
                    MessageBox.Show("not found");
                else
                    MessageBox.Show("found " + a);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                ExcepLog.Excep(exp);
            }
            finally
            {
                workBook.Close();
                excelApp.Quit();
            }
        }
    }
}
