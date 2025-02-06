using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ferreteria
{
    class ExcelExport
    {
        public ExcelExport() { }
        public void PrintGridView(string Titulo1, string Titulo2, GridView gridView)
        {
            //Creacion de Excel (Aplicacion, Libro, Hoja)
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            //Titulo 1
            Microsoft.Office.Interop.Excel.Range range1;
            sheet.Cells[1, 1] = Titulo1;
            range1 = sheet.get_Range("A1", "I1");
            range1.EntireRow.Font.Bold = true;
            range1.Font.Size = 16;
            range1.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkGreen);
            range1.HorizontalAlignment = 3;
            range1.VerticalAlignment = 3;
            range1.Merge(true);
            //Titulo 2
            Microsoft.Office.Interop.Excel.Range range2;
            sheet.Cells[3, 1] = Titulo2;
            range2 = sheet.get_Range("A3", "I3");
            range2.EntireRow.Font.Bold = true;
            range2.Font.Size = 14;
            range2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkGreen);
            range2.HorizontalAlignment = 3;
            range2.VerticalAlignment = 3;
            range2.Merge(true);
            //Encabezados
            string[] header = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "l", "M", "N", "O", "P", "Q", "R", "S", "T", "U" };
            int startRow = 6;
            for (int i = 1; i <= gridView.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range;
                if (gridView.Columns[i - 1].Visible == true)
                {
                    sheet.Cells[startRow, i] = gridView.Columns[i - 1].Caption;
                    range = sheet.get_Range(header[i - 1] + startRow.ToString(), header[i - 1] + startRow.ToString());
                    range.EntireRow.Font.Bold = true;
                }
            }
            //Campos de la tabla
            List<string> fieldnames = new List<string>();
            for (int i = 0; i < gridView.Columns.Count; i++)
                fieldnames.Add(gridView.Columns[i].FieldName);
            //Recorrido de la tabla y escritura en Excel
            for (int i = startRow + 1, j = 0; j < gridView.RowCount; j++)
            {
               for (int k = 0; k < gridView.Columns.Count; k++)
                {
                    if (gridView.Columns[k].Visible =! false)
                    {
                        if (gridView.GetRowCellValue(j, fieldnames[k]) != null)
                        {
                            string value = gridView.GetRowCellValue(j, fieldnames[k]).ToString();
                            if (gridView.Columns[k].DisplayFormat.FormatType == DevExpress.Utils.FormatType.DateTime)
                            {
                                DateTime date = Convert.ToDateTime(value);
                                string fecha = date.ToString("dd/MM/yyyy");
                                sheet.Cells[i, k + 1] = fecha;
                            }
                            else
                            {
                                sheet.Cells[i, k + 1] = value;
                            }
                        }
                        else
                        {
                            sheet.Cells[i, k + 1] = "";
                        }
                    }
                }
                i++;
            }
            excel.Visible = true;
        }
        //Sobrecarga de la funcion PrintGridView para agregar un total en la ultima fila 
        public void PrintGridView(string Titulo1, string Titulo2, GridView gridView, int columnTotal )
        {
            //Creacion de Excel (Aplicacion, Libro, Hoja)
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            //Titulo 1
            Microsoft.Office.Interop.Excel.Range range1;
            sheet.Cells[1, 1] = Titulo1;
            range1 = sheet.get_Range("A1", "I1");
            range1.EntireRow.Font.Bold = true;
            range1.Font.Size = 16;
            range1.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkGreen);
            range1.HorizontalAlignment = 3;
            range1.VerticalAlignment = 3;
            range1.Merge(true);
            //Titulo 2
            Microsoft.Office.Interop.Excel.Range range2;
            sheet.Cells[3, 1] = Titulo2;
            range2 = sheet.get_Range("A3", "I3");
            range2.EntireRow.Font.Bold = true;
            range2.Font.Size = 14;
            range2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkGreen);
            range2.HorizontalAlignment = 3;
            range2.VerticalAlignment = 3;
            range2.Merge(true);
            //Encabezados
            string[] header = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "l", "M", "N", "O", "P", "Q", "R", "S", "T", "U" };
            int startRow = 6;
            for (int i = 1; i <= gridView.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range;
                if (gridView.Columns[i - 1].Visible == true)
                {
                    sheet.Cells[startRow, i] = gridView.Columns[i - 1].Caption;
                    range = sheet.get_Range(header[i - 1] + startRow.ToString(), header[i - 1] + startRow.ToString());
                    range.EntireRow.Font.Bold = true;
                }
            }
            //Campos de la tabla
            List<string> fieldnames = new List<string>();
            for (int i = 0; i < gridView.Columns.Count; i++)
                fieldnames.Add(gridView.Columns[i].FieldName);
            //Recorrido de la tabla y escritura en Excel
            float total = 0;
            for (int i = startRow + 1, j = 0; j < gridView.RowCount; j++)
            {
                for (int k = 0; k < gridView.Columns.Count; k++)
                {
                    if (gridView.Columns[k].Visible = !false)
                    {
                        if (gridView.GetRowCellValue(j, fieldnames[k]) != null)
                        {
                            string value = gridView.GetRowCellValue(j, fieldnames[k]).ToString();
                            if (gridView.Columns[k].DisplayFormat.FormatType == DevExpress.Utils.FormatType.DateTime)
                            {
                                DateTime date = Convert.ToDateTime(value);
                                string fecha = date.ToString("dd/MM/yyyy");
                                sheet.Cells[i, k + 1] = fecha;
                            }
                            else
                            {
                                sheet.Cells[i, k + 1] = value;
                                if (columnTotal == k)
                                {
                                     total += float.Parse(value);
                                }
                            }
                        }
                        else
                        {
                            sheet.Cells[i, k + 1] = "";
                        }
                    }
                }
                i++;
            }
            sheet.Cells[gridView.RowCount +2, 4] = "Total="+total;
            excel.Visible = true;
        }
        //Sobrecarga de la funcion PrintGridView para agregar un total en la ultima fila y cambiar el formato de la fecha
        public static string ChangeDate(DateTime date)
        {
            switch ((date.Day))
            {
                case 1:
                case 21:
                case 31:
                    return date.ToString("d'st' MMMM yyyy");
                case 2:
                case 22:
                    return date.ToString("d'nd' MMMM yyyy");
                case 3:
                case 23:
                    return date.ToString("d'rd' MMMM yyyy");
                default:
                    return date.ToString("d'th' MMMM yyyy");
            }
        }
    }
}
