using System;


namespace Data.Entity;

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
      => new PhanSo(a.TS * b.MS + b.TS * a.MS, a.MS * b.MS);
    public static PhanSo operator -(PhanSo a, PhanSo b)
     => new PhanSo(a.TS * b.MS - b.TS * a.MS, a.MS * b.MS);

    public static PhanSo operator *(PhanSo a, PhanSo b)
     => new PhanSo(a.TS * b.TS, a.MS * b.MS);

    public static PhanSo operator /(PhanSo a, PhanSo b)
     => b.TS / b.MS == 0 ? throw new DivideByZeroException() : new PhanSo(a.TS * b.MS, a.MS * b.TS);

    public static PhanSo TinhToan(PhanSo a, PhanSo b, string pheptinh)
        => pheptinh switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => a * b,

        };

    public override string ToString()
    => $"{TS} / {MS}";
}
