using Data.Entity;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helper
{
    public class EmployeeExcelReader
    {
        public List<Employee> Read()
        {
            var list = new List<Employee>();
            var fileExcel = ConfigurationManager.AppSettings["ExcelFile"];
            ExcelPackage.License.SetNonCommercialPersonal("Dương");

            using var package = new ExcelPackage(new FileInfo(fileExcel));
            var ws = package.Workbook.Worksheets["DSNV"];

            int rows = ws.Dimension.Rows;

            for (int row = 2; row <= rows; row++)
            {
                try
                {
                    int.TryParse(ws.Cells[row, 1].Text, out int id);
                    string name = ws.Cells[row, 2].Text;
                    double.TryParse(ws.Cells[row, 3].Text, out double salary);

                    list.Add(new Employee(id, name, salary));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error row {row}: {ex.Message}");
                }
            }

            return list;
        }
    }
}
