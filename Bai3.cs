using OfficeOpenXml;
using System.Configuration;

namespace CSharpLearning;

    public class Student_Manager
    {
    public List <SinhVien> DataFromFile()
    {
        var list = new List<SinhVien>();
        ExcelPackage.License.SetNonCommercialPersonal("Dương");
        var fileExcel = ConfigurationManager.AppSettings["ExcelFile"];
        using (var package = new ExcelPackage(new FileInfo(fileExcel)))
        {
            var worksheet = package.Workbook.Worksheets["DSSV"];
            int rows = worksheet.Dimension.Rows;
            int cols = worksheet.Dimension.Columns;
            
                for (int row = 2; row <= rows; row++)
                {
                    string id = worksheet.Cells[row, 1].Text;
                    string name = worksheet.Cells[row, 2].Text;
                    int age = int.Parse(worksheet.Cells[row, 3].Text);
                    double gpa1 = double.Parse(worksheet.Cells[row, 4].Text);
                    double gpa2 = double.Parse(worksheet.Cells[row, 5].Text);

                    var student = new SinhVien(id, name, age, gpa1, gpa2);
                    list.Add(student);
                }



            

        }
    return list;
    }
   }

