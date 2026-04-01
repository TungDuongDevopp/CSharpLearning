using Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Data.Entity;

public struct SinhVien

{   public string Id { get; set; }

    public string Name { get; set; }
    public int Age { get; set; }

    public double GPA1 { get; set; }
    public double GPA2 { get; set; }

    public DateTime Birthday { get; set; }

    public SinhVien(string id, string name, int age, DateTime birthday, double gpa1, double gpa2)
    {
        Id = id;
        Name = name;
        Age = age;
        Birthday = birthday;
        GPA1 = gpa1;
        GPA2 = gpa2;
    }
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age},Birthday: {Birthday}, GPA1: {GPA1}, GPA2: {GPA2}";
    }
    public string DanhGiaHocLuc(SinhVien a)
    {
        double diemTb = (a.GPA1 + a.GPA2) / 2;

        return diemTb switch
        {
            >= 9.0 => HocLuc.Xuatsac.ToString(),
            >= 8.0 => HocLuc.Gioi.ToString(),
            >= 6.5 => HocLuc.Kha.ToString(),
            >= 5.0 => HocLuc.TrungBinh.ToString(),
            _ => HocLuc.Yeu.ToString()
        };
    }
    public 

    enum HocLuc { Xuatsac, Gioi, Kha, TrungBinh, Yeu };
}
