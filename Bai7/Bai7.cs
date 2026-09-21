// so nguyen to
class Bai7
{
    //xet coi phai so ngto khong
   public bool Isprime(int n)
    {
        if(n<2)// be hon 2 khong la so ngto
        return false;

        for(int i=2;i<n;i++)
        {
            if(n%i==0)
            return false;
        }
        return true;
    } 
}
class Program()
{
    static void Main()
    {
        Bai7 bai7=new Bai7();
        bool result=bai7.Isprime(5);
        Console.WriteLine("la so nguyen to:"+result);
    }
}