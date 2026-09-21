//dao chuoi
class Bai11
{
    public string Daochuoi(string s)
    {
        string result="";
        for(int i=s.Length-1;i>=0;i--)//vong lap duyet duyet chuoi tu ky cuoi den dau
        {
            result=result+s[i];
        }
        return result;
    }
}
class Program()
{
    static void Main()
    {
    Bai11 bai11=new Bai11();
    string s="hello world";
    string result=bai11.Daochuoi(s);
    Console.WriteLine("chuoi sau khi dao: "+result);
    }
}