//tim so lon nhat va so be nhat
class Bai9
{
    public void TimMaxmin(double x, double y, double z, out double max, out double min)
    {
        max = x;
        min = x;

        if (y>max)
            max = y;

        if (z>max)
            max = z;

        if (y<min)
            min = y;

        if (z<min)
            min = z;
    }
}
class Program
{
    static void Main()
    {
        Bai9 bai9 = new Bai9();
        double max;
        double min;

        bai9.TimMaxmin(5, 10, 3, out max, out min);
        Console.WriteLine("Gia tri lon nhat: " + max);
        Console.WriteLine("Gia tri nho nhat: " + min);
    }
}