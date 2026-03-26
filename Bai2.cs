using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning;

 public struct PhanSo
{
    int TS, MS;

    public PhanSo(int TS, int MS)
    {
        this.TS = TS;
        this.MS = MS;
        RutGon();
    }
    private int TimUCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (a != 0 && b != 0)
        {
            if (a > b) a %= b;
            else b %= a;
        }
        return a | b;
    }

    // Phương thức rút gọn
    public void RutGon()
    {
        int ucln = TimUCLN(TS, MS);
        TS /= ucln;
        MS /= ucln;
    }

    public static PhanSo operator +(PhanSo a, PhanSo b)
      => new PhanSo(a.TS* b.MS + b.TS * a.MS, a.MS * b.MS);
    public static PhanSo operator - (PhanSo a, PhanSo b)
     => new PhanSo(a.TS * b.MS - b.TS * a.MS, a.MS * b.MS);

    public static PhanSo operator * (PhanSo a, PhanSo b)
     => new PhanSo(a.TS * b.TS, a.MS * b.MS);

    public static PhanSo operator / (PhanSo a, PhanSo b)
     => b.TS/b.MS == 0 ? throw new DivideByZeroException() : new PhanSo(a.TS * b.MS, a.MS * b.TS);

    public static PhanSo TinhToan(PhanSo a, PhanSo b, string pheptinh)
        => pheptinh switch
        { "+" =>  a+b,
          "-" => a-b,
          "*" => a*b,
          "/" => a*b,

        };

    public override string ToString()
    => $"{TS} / {MS}";
}

public struct SinhVien
{
    string Id, Name;
    int Age;
    double GPA1, GPA2;

    public SinhVien(string id, string name, int age, double gpa1, double gpa2)
    {
        Id = id;
        Name = name;
        Age = age;
        GPA1 = gpa1;
        GPA2 = gpa2;
    }
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}, GPA1: {GPA1}, GPA2: {GPA2}";
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

    enum HocLuc { Xuatsac, Gioi, Kha, TrungBinh, Yeu };
}
