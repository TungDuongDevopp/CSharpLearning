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
    public class UserExcelReader
    {
        public List<Employee> ReadEmployeeList()
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

        public List<SinhVien> ReadStudentList()
        {
            var list = new List<SinhVien>();
            var fileExcel = ConfigurationManager.AppSettings["ExcelFile"];
            ExcelPackage.License.SetNonCommercialPersonal("Dương");
            using var package = new ExcelPackage(new FileInfo(fileExcel));
            var ws = package.Workbook.Worksheets["DSSV"];
            int rows = ws.Dimension.Rows;
            string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "d/MM/yyyy", "dd/M/yyyy" };
            for (int row = 2; row <= rows; row++)
            {
                try

                {
                    string id = ws.Cells[row, 1].Text;
          
                    string name = ws.Cells[row, 2].Text;
                    int.TryParse(ws.Cells[row, 3].Text, out int age);
                    DateTime.TryParseExact(ws.Cells[row, 4].Text, formats, null, System.Globalization.DateTimeStyles.None, out DateTime birthday);
                    double.TryParse(ws.Cells[row, 5].Text, out double gpa1);
                    double.TryParse(ws.Cells[row, 6].Text, out double gpa2);

                    list.Add(new SinhVien(id, name, age, birthday, gpa1, gpa2));
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
