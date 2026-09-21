//tim gia tri lon nhat
using System.Xml.Serialization;

class Bai6
{
    //tim gtln
    public int TimGTLN(int x, int y, int z)
    {
        int max=x;
        if(y>max)
        max=y;
        if(z>max)
        max=z;

        return max;
    }
}
class Program
{
    public static void Main()
    {
        Bai6 bai6= new Bai6();
        int result=bai6.TimGTLN(10,20,5);//gan so cho x,y,z
        Console.WriteLine("gia tri lon nhat: "+result);
    }
}
