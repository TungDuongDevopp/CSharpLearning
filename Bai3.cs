using OfficeOpenXml;
using System.Configuration;
using System.Globalization;

namespace CSharpLearning;

    public class Student_Manager
    {
    public List<SinhVien> DataFromFile()
    {
        var validate = new Validate();
        var list = new List<SinhVien>();
        ExcelPackage.License.SetNonCommercialPersonal("Dương");
        var fileExcel = ConfigurationManager.AppSettings["ExcelFile"];

        using (var package = new ExcelPackage(new FileInfo(fileExcel)))
        {
            var worksheet = package.Workbook.Worksheets["DSSV"];
            int rows = worksheet.Dimension.Rows;

            for (int row = 2; row <= rows; row++)
            {
                // Lấy giá trị thô từ Excel
                var data = new List<string> {
                worksheet.Cells[row, 1].Text, // ID
                worksheet.Cells[row, 2].Text, // Name
                worksheet.Cells[row, 3].Text, // Age
                worksheet.Cells[row, 4].Text, // Birthday
                worksheet.Cells[row, 5].Text, // GPA1
                worksheet.Cells[row, 6].Text  // GPA2
            };

                var validated = validate.ValidateData(data);

                // KIỂM TRA: Đảm bảo List trả về đủ 6 cột mới tạo SinhVien
                if (validated.Count == 6)
                {
                    try
                    {
                        var student = new SinhVien(
                            validated[0]?.ToString(),
                            validated[1]?.ToString(),
                            Convert.ToInt32(validated[2] ?? 0),     // Tránh null cho int
                            validated[3] is DateTime dt ? dt : DateTime.MinValue, // Ép kiểu an toàn
                            Convert.ToDouble(validated[4] ?? 0),
                            Convert.ToDouble(validated[5] ?? 0)
                        );
                        list.Add(student); // Đừng quên add vào list để return!
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi tại dòng {row}: {ex.Message}");
                    }
                }
            }
        }
        return list;
    }
}
   

