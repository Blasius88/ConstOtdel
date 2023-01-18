using System;
using static WpfApp1.Accessories;
using static WpfApp1.Hardware;
using static WpfApp1.Suppliers_Hadware;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows;
using Microsoft.Office.Interop.Excel;
using System.Threading;

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
                if (ExcelFilePath != "")
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
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                ExcepLog.Excep(exp);
            }
            finally
            {
                if (ExcelFilePath != "")
                {
                    workBook.Close();
                    excelApp.Quit();
                }
            }
        }

        /// <summary>
        /// Загрузка файла с фурнитурой и поставщиками  
        /// </summary>
        /// <param name="excel_file_path"></param> 
        public static void Downloud_Hardware_Suppliers(string excel_file_path)
        {
            bool find = false;
            try
            {
                if (excel_file_path != "")
                {
                    excelApp = new Excel.Application();
                    workBook = excelApp.Workbooks.Open(excel_file_path);
                    workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
                    range = workSheet.UsedRange;
                    for (int cCnt = 1; cCnt <= range.Rows.Count; cCnt++)
                    {
                        string str = Convert.ToString(workSheet.Cells[cCnt, 1].Value);
                        if (str != "" && 
                            str != null)
                        {
                            //проверка поставщика и запись его ID 
                            if (Сheck_name_suppliers_hardwre.Check(Convert.ToString(workSheet.Cells[cCnt, 1].Value)))
                            {
                                Suppliers_Hadware suppliers_Hadware = new Suppliers_Hadware
                                {
                                    ID = cCnt, // записывает не правильный ID ( пишет номер строчки ) 
                                    Name = Convert.ToString(workSheet.Cells[cCnt, 1].Value)
                                };
                                if (Convert.ToString(suppliers_Hadware.Name) != "")
                                {
                                    list_suppliers_hardware.Add(suppliers_Hadware);
                                }
                            }
                            Hardware hardware = new Hardware
                            {
                                Supplier_Name = Convert.ToInt16(Supplier_availability_check.Check(workSheet.Cells[cCnt, 1].Value)),
                                Hardware_Name = Convert.ToString(workSheet.Cells[cCnt, 2].Value),
                                Description = Convert.ToString(workSheet.Cells[cCnt, 3].Value),
                                Color = Convert.ToString(workSheet.Cells[cCnt, 4].Value)
                            };
                            list_hardware.Add(hardware);
                            find = true;
                        }
                    }
                    if (!find)
                        MessageBox.Show("произошла ошибка. Фурнитура не найдена");
                    else
                        MessageBox.Show("загрузка завершена");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                ExcepLog.Excep(exp);
            }
            finally
            {
                if (excel_file_path != "")
                {
                    workBook.Close();
                    excelApp.Quit();
                }
            }
        }
    }
}
