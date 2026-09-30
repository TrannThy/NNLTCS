using System;

// DELEGATE
delegate int SoSanh<T>(T a, T b);

// LOP SinhVien1
class SinhVien1
{
    // FIELD
    private string hoTen;
    private double diem;

    // CONSTRUCTOR
    public SinhVien1(string hoTen, double diem)
    {
        this.hoTen = hoTen;
        this.diem = diem;
    }

    // METHOD
    public double LayDiem()
    {
        return diem;
    }

    // METHOD
    public void Output()
    {
        Console.WriteLine(hoTen + " - " + diem);
    }
}

// LOP SAP XEP
class SapXep1
{
    // METHOD TONG QUAT
    public static void Sort<T>(T[] a, SoSanh<T> ss)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (ss(a[i], a[j]) > 0)
                {
                    T temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }
}

class Bai3_3
{
    // PHUONG THUC SO SANH
    static int SoSanhDiem(SinhVien1 a, SinhVien1 b)
    {
        return a.LayDiem().CompareTo(b.LayDiem());
    }

    static void Main()
    {
        SinhVien1[] ds =
        {
            new SinhVien1("Thy", 8.5),
            new SinhVien1("Binh", 9.5),
            new SinhVien1("Chi", 6.5),
            new SinhVien1("Dung", 8.0)
        };

        // SAP XEP TANG DAN THEO DIEM
        SapXep1.Sort(ds, SoSanhDiem);

        Console.WriteLine("Danh sach sau khi sap xep:");

        for (int i = 0; i < ds.Length; i++)
        {
            ds[i].Output();
        }
    }
}