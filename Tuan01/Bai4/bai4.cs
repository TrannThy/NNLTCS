//tinh luy thua neu x y laf so nguyen
Console.Write("nhap so nguyen x: ");
int x;
if (!int.TryParse(Console.ReadLine(), out x))//kiêm tra so nguyen x
{
    Console.WriteLine("x khong phai so nguyen");
    return;
}

Console.Write("nhap so nguyen y: ");
int y;
if (!int.TryParse(Console.ReadLine(), out y))//kiem tra so nguyen y
{
    Console.WriteLine("y khong phai so nguyen");
    return;
}

int result=(int)Math.Pow(x,y);
Console.WriteLine("ket qua "+x+"mu "+y+"la: "+result);


