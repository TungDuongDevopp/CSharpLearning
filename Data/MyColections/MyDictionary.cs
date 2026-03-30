namespace Data.MyColections;


public class MyDictionary
{
    public static readonly Dictionary<string, string> phonenumber = new Dictionary<string, string>
    {
        ["Dương"] = "034576153",
        ["Mai"] = "0979032263",
        ["Vy"] = "0358045477",
        ["Huấn"] = "0978794415",
        ["Nụ"] = "0358498723"

    };
    public void printDict()
    {
        
        foreach (var kvp in phonenumber)
        {
            Console.WriteLine($"[{kvp.Key}] = {kvp.Value}");
        }
    }

}
