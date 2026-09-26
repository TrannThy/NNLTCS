//menu tinh luy thua, tinh can bac 2
double x=0;
double y=0;
int chon;
//menu
do
{
    Console.WriteLine("menu:");
    Console.WriteLine("1. nhap hai gia tri so thuc cho x,y");
    Console.WriteLine("2. tinh x^y");
    Console.WriteLine("3. tinh can bac 2 cua x va y");
    Console.WriteLine("4. thoat");
    chon=int.Parse(Console.ReadLine()!);

    switch(chon)
    {
        case 1://nhap x va y
        Console.WriteLine("nhap x: ");
        x=double.Parse(Console.ReadLine()!);
        Console.WriteLine("nhap y: ");
        y=double.Parse(Console.ReadLine()!);
        break;

        case 2://tinh x mu y
        Console.WriteLine("x^y: "+Math.Pow(x,y));
        break;

        case 3://tinh can cua x va y
        Console.WriteLine("can x: "+ Math.Sqrt(x));
        Console.WriteLine("can y: "+ Math.Sqrt(y));
        break;

    }
}
while (chon!=4);