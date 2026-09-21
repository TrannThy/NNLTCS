//chuoi doi xung
class Bai10
{
    public bool Kiemtradoixung(string s)
    {   //so sanh ky tu dau tien voi ki tu cuoi
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - 1 - i])//neu ky tu ben trai khac ben phải
                return false;
        }
        return true;
    }
}
class Program
{
    static void Main()
    {
        Bai10 bai10 = new Bai10();
        string s = "helleh";

        bool result = bai10.Kiemtradoixung(s);
        Console.WriteLine("Chuoi doi xung: " + result);
    }
}