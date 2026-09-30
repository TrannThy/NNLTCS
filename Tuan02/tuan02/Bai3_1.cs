using System;

class SinhVien : IComparable<SinhVien>
{
    // FIELD
    private string hoTen;
    private double diem;

    // CONSTRUCTOR
    public SinhVien(string hoTen, double diem)
    {
        this.hoTen = hoTen;
        this.diem = diem;
    }

    // METHOD
    public int CompareTo(SinhVien sv)
    {
        return diem.CompareTo(sv.diem);
    }

    // METHOD
    public void Output()
    {
        Console.WriteLine(hoTen + " - " + diem);
    }
}

class Bai3_1
{
    static void Main()
    {
        SinhVien[] ds =
        {
            new SinhVien("Thy", 7.5),
            new SinhVien("Binh", 9.0),
            new SinhVien("Chi", 6.5),
            new SinhVien("Dung", 8.0)
        };

        // Su dung Array.Sort de sap xep
        Array.Sort(ds);

        Console.WriteLine("Danh sach sau khi sap xep:");

        for (int i = 0; i < ds.Length; i++)
        {
            ds[i].Output();
        }
    }
}