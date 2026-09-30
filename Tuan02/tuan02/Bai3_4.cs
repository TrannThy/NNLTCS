using System;

// DELEGATE
delegate void ChooseHandler(int x);

// LỚP MENU
class ConsoleMenu
{
    // EVENT
    public event ChooseHandler Choose;

    // METHOD
    public void Run()
    {
        int x;

        do
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Giai phuong trinh bac 2");
            Console.WriteLine("0. Thoat chuong trinh");
            Console.Write("Thuc hien: ");

            x = int.Parse(Console.ReadLine()!);

            if (x != 0)
            {
                Choose?.Invoke(x);
            }

        } while (x != 0);
    }
}

// LỚP GIẢI PHƯƠNG TRÌNH
class PTBac2Console
{
    // METHOD
    public void GiaiPTBac2()
    {
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine()!);

        if (a == 0)
        {
            Console.WriteLine("Day khong phai phuong trinh bac 2.");
            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}

class Bai3_4
{
    static void Main()
    {
        ConsoleMenu app = new ConsoleMenu();

        PTBac2Console pt = new PTBac2Console();

        app.Choose += (x) =>
        {
            if (x == 1)
            {
                pt.GiaiPTBac2();
            }
            else
            {
                Console.WriteLine("Chuc nang khong ton tai.");
            }
        };

        app.Run();
    }
}