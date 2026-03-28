

using System.Globalization;

namespace CSharpLearning;

public  class Validate
{

    public List<object> ValidateData(List<string> value)
    {
        string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "d/MM/yyyy", "dd/M/yyyy" };
        List<object> obj = new List<object>();

        foreach (var item in value)
        {
            string trimmedItem = item?.Trim();

            // 1. Kiểm tra trống
            if (string.IsNullOrWhiteSpace(trimmedItem))
            {
                obj.Add(null); // Giữ chỗ để không bị lệch cột
                continue;
            }

            // 2. Ưu tiên Parse Ngày tháng trước (vì nó khắt khe nhất)
            if (DateTime.TryParseExact(trimmedItem, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                obj.Add(date);
            }
            // 3. Kiểm tra số nguyên
            else if (int.TryParse(trimmedItem, out int numberInt))
            {
                obj.Add(numberInt);
            }
            // 4. Kiểm tra số thực
            else if (double.TryParse(trimmedItem, out double numberDouble))
            {
                obj.Add(numberDouble);
            }
            // 5. Nếu không là gì cả thì giữ nguyên là String (Tên, Mã SV...)
            else
            {
                obj.Add(trimmedItem);
            }
        }
        return obj;
    }

}
