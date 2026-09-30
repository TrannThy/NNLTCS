using System;

// INTERFACE
interface ISoSanh<T>
{
    int CompareTo(T x);
}

// LOP SinhVien
class sinhVien : ISoSanh<sinhVien>
{
    // FIELD
    private string hoTen;
    private double diem;

    // CONSTRUCTOR
    public sinhVien(string hoTen, double diem)
    {
        this.hoTen = hoTen;
        this.diem = diem;
    }

    // METHOD
    public int CompareTo(sinhVien sv)
    {
        return diem.CompareTo(sv.diem);
    }

    // METHOD
    public void Output()
    {
        Console.WriteLine(hoTen + " - " + diem);
    }
}

// LOP CHUA PHUONG THUC SAP XEP
class SapXep
{
    // METHOD TONG QUAT
    public static void Sort<T>(T[] a) where T : ISoSanh<T>
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i].CompareTo(a[j]) > 0)
                {
                    T temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }
}

class Bai3_2
{
    static void Main()
    {
        sinhVien[] ds =
        {
            new sinhVien("Thy", 7.5),
            new sinhVien("Binh", 9.0),
            new sinhVien("Chi", 6.5),
            new sinhVien("Dung", 8.0)
        };

        // Goi phuong thuc sap xep tu viet
        SapXep.Sort(ds);

        Console.WriteLine("Danh sach sau khi sap xep:");

        for (int i = 0; i < ds.Length; i++)
        {
            ds[i].Output();
        }
    }
}