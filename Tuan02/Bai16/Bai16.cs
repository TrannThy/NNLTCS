class Bai16
{
    public string[] a;
    //nhap mang
    public void Nhap()
    {
        Console.Write("nhap so nguoi: ");
        int n=int.Parse(Console.ReadLine()!);
        a=new string[n];

        for (int i=0;i<n; i++)
        {
            Console.Write("nhap ho ten nguoi "+(i+1)+": ");
            a[i]=Console.ReadLine()!;
        }
    }
    //sap xep theo thu tu tang dan
    public void Sapxep()
    {
        for (int i=0;i<a.Length-1;i++) //xet tung ten trong mang
        {
            for (int j=i+1;j<a.Length;j++)
            {
                if (string.Compare(a[i],a[j])>0) //so sanh 2 ten canh nhau
                {
                    string temp = a[i]; //hoan vi
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }
    //xuat mang
    public void Xuat()
    {
        for (int i=0;i<a.Length;i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Bai16 bai16 = new Bai16();

        bai16.Nhap();
        bai16.Sapxep();
        bai16.Xuat();
    }
}