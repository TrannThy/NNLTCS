//hoan vi
class Bai8
{
    public void Hoanvi(ref double x, ref double y)
    {
        double term=x;//hoan vi 2 x va y
        x=y;
        y=term;
    }
}
class Program()
{
    static void Main()
    {
        Bai8 bai8=new Bai8();
        double x=5;
        double y=10;
        
        Console.WriteLine("ta co: x="+x+" y="+y);
        bai8.Hoanvi(ref x, ref y);
        Console.WriteLine("sau khi hoan vi: x= "+x+" y="+y);
    }
}