using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Working_with_form
{
    public class ExcelHelper: IDisposable
    {
        private string _filePath;

        public static Excel.Application application;
        public static Excel.Workbooks workbooks;
        public static Excel.Workbook workbook;
        public static Excel.Sheets worksheets;
        public static Excel.Worksheet worksheet;
        public static Excel.Range cells;
        public static Excel.Window window;

        public static string FileName { get; internal set; }

        public ExcelHelper()
        {
            application = new Excel.Application();
        }

        public Excel.Application StartExcel()
        {
            try
            {
                application = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
            }
            catch (COMException)
            {
                application = new Excel.Application();
            }
            return application;
        }

        /// <summary>
        /// Открывает excel файл
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public void OpenFile(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    // Присоединение к открытому приложению Excel (если оно открыто), имхо так тру, ибо 2 excel процесса в памяти не кошерно
                    application = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
                    workbook = application.Workbooks.Open(filepath);
                }
                else
                {
                    application = new Excel.Application(); // Если нет открытого, то создаём новое приложение
                    workbook = application.Workbooks.Add();
                }
            }
            catch (Exception) { MessageBox.Show("File not exist!"); }
        }

        /// <summary>
        /// Создание новой книги  
        /// </summary>
        public void CreateNewFile()
        {
            application = new Excel.Application();
            workbook = application.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        }

        /// <summary>
        /// Создание нового листа
        /// </summary>
        public void CreateNewSheet()
        {
            Worksheets tempsheet = workbook.Worksheets.Add(After: worksheet);
            worksheet = workbook.Worksheets[1];
        }

        public string GetNameSheets()
        {
            int countSheet = workbook.Worksheets.Count;
            string sheetName = "";
            foreach (Excel.Worksheet item in workbook.Worksheets)
            {
                sheetName += item.Name + Environment.NewLine;
            }
          return sheetName;

        }

        /// <summary>
        /// Получение первого лист документа (счет начинается с 1)
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Worksheet SelectWorksheet(int sheet)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            return worksheet;
        }

        /// <summary>
        /// Получение первого лист документа (счет начинается с 1)
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Worksheet SelectWorksheet(string sheet)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            return worksheet;
        }

        /// <summary>
        /// Выбор нужного листа
        /// </summary>
        /// <param name="SheetNumber"></param>
        public void GetWorksheet(int SheetNumber)
        {
            worksheet = workbook.Worksheets[SheetNumber];
        }
        
        /// <summary>
        /// Удаление нужного листва
        /// </summary>
        /// <param name="SheetNumber"></param>
        public void DeleteWorksheet(int SheetNumber)
        {
            workbook.Worksheets[SheetNumber].Delete();  
        }

        /// <summary>
        /// Переименовывает лист
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public Worksheet RenameWorksheet(int sheet, string str)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);
            worksheet.Name = str;
            return worksheet;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ProtectSheet()
        {
            worksheet.Protect();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        public void ProtectSheet(string Password) 
        {
              worksheet.Protect(Password);
        }
        /// <summary>
        /// 
        /// </summary>
        public void UnprotectSheet()
        {
            worksheet.Unprotect();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        public static void UnprotectSheet(int Password)
        {
            worksheet.Unprotect(Password);
        }

        /// <summary>
        /// Определяет последнюю заполненную строку
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        public int LastRowCell(string sheet)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к листу
            cells =  worksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell); //получаем доступ к ячейки
            int lastrow = cells.Row;
            return lastrow;
        }
        public int LastRowCell(int sheet)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к листу
            cells = worksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell); //получаем доступ к ячейки
            int lastrow = cells.Row;
            return lastrow;
        }

        /// <summary>
        /// Читает данные из excel файла, на определенном листе в определенной ячейке
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public string ReadCell(int sheet, int row, int column)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            cells = worksheet.Cells[row, column];  //получаем доступ к нужной ячейке
            if (cells.Cells[row, column] != null && cells.Value != null)
            {
                string data = cells.Value.ToString();
                return data;
            }
            else
            {
                return " ";
            }
        }

        /// <summary>
        /// Читает данные из excel файла, на определенном листе в определенной ячейке
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public string ReadCell(string sheet, int row, int column)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            cells = worksheet.Cells[row, column];  //получаем доступ к нужной ячейке
            if (cells.Cells[row, column] != null && cells.Value != null)
            {
                string data = cells.Value.ToString();
                return data;
            }
            else
            {
                return " ";
            }
        }

        /// <summary>
        /// Читает диапазон данных из Excel файла, на определенном листе в определенной области (Пока не работает!)
        /// </summary>
        /// <param name="starti"></param>
        /// <param name="starty"></param>
        /// <param name="endi"></param>
        /// <param name="endy"></param>
        /// <returns></returns>
        public string[,] ReadRange(int sheet, int starti, int starty, int endi, int endy)
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            Range range = (Range)worksheet.Range[worksheet.Cells[starti, starty], worksheet.Cells[endi, endy]];
            object[,] holder = range.Value;
            string[,] data = new string[endi - starti, endy - starty];
            for (int p = 1; p <= endi - starti; p++)
            {
                for (int q = 1; q <= endy - starty; q++)
                {
                    data[p - 1 , q - 1] = holder[p, q].ToString();
                }
            }
            return data;
        }

        /// <summary>
        /// Вводит данные в excel файла, на определенном листе в определенной ячейке
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="data"></param>
        public void WriteCell(int sheet, int row, int column, object data)
        {
            try
            {
                //worksheet = worksheets.Item[1]; //получаем доступ к первому листу
                worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
                cells =  worksheet.Cells[row, column];  //получаем доступ к нужной ячейке
                cells.Value = data; // заполняем ячейку
            }
            catch(Exception) { MessageBox.Show("it didn't work out!"); }
        }

        /// <summary>
        /// Вводит данные в excel файла, на определенном листе в определенной ячейке
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="data"></param>
        public void WriteCell(string sheet, int row, int column, object data)
        {
            try
            {
                //worksheet = worksheets.Item[1]; //получаем доступ к первому листу
                worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
                cells = worksheet.Cells[row, column];  //получаем доступ к нужной ячейке
                cells.Value = data; // заполняем ячейку
            }
            catch (Exception) { MessageBox.Show("it didn't work out!"); }
        }

        /// <summary>
        /// Записывает диапазон данных в Excel файл, на определенном листе в определенной области
        /// </summary>
        /// <param name="starti"></param>
        /// <param name="starty"></param>
        /// <param name="endi"></param>
        /// <param name="endy"></param>
        /// <param name="data"></param>
        public void WriteRange(int sheet, int starti, int starty, int endi, int endy, string[,] data)  
        {
            worksheet = (Worksheet)application.Worksheets.get_Item(sheet);//получаем доступ к первому листу
            Range range = (Range)worksheet.Range[worksheet.Cells[starti, starty], worksheet.Cells[endi, endy]];
            range.Value = data;
        }
    
        /// <summary>
        /// Сохраняет файл
        /// </summary>
        public void Save()
        {
            if (!string.IsNullOrEmpty(_filePath))
            {
                workbook.SaveAs(_filePath);
                _filePath = null;
            }
            else
            {
                workbook.Save();
            }
        }

        /// <summary>
        /// Закрывает Excel и освобождает память
        /// </summary>
        public void Dispose()
        {
            try
            {
                application.Quit();
                Marshal.FinalReleaseComObject(application);
                GC.Collect();
            }
            catch (Exception) { MessageBox.Show("File not opened!"); }
        }
    }
}
