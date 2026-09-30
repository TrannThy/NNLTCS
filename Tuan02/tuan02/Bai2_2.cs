using System;
using System.Collections;

class person
{
    private int id;
    private string name;
    private int yob;
    private int yod;

    public person()
    {
        id = 0;
        name = "";
        yob = 0;
        yod = 0;
    }

    public person(person p)
    {
        id = p.id;
        name = p.name;
        yob = p.yob;
        yod = p.yod;
    }

    public void Input()
    {
        Console.Write("Nhap id: ");
        id = int.Parse(Console.ReadLine()!);

        Console.Write("Nhap ten: ");
        name = Console.ReadLine()!;

        Console.Write("Nhap nam sinh: ");
        yob = int.Parse(Console.ReadLine()!);

        Console.Write("Nhap nam mat (0 neu con song): ");
        yod = int.Parse(Console.ReadLine()!);
    }

    public void Output()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Ten: " + name);
        Console.WriteLine("Nam sinh: " + yob);
        Console.WriteLine("Nam mat: " + yod);
    }

    public bool IsLiving()
    {
        return yod == 0;
    }
}

class PersonList
{
    // FIELD
    private ArrayList dsPerson;

    // DEFAULT CONSTRUCTOR
    public PersonList()
    {
        dsPerson = new ArrayList();
    }

    // COPY CONSTRUCTOR
    public PersonList(PersonList p)
    {
        dsPerson = new ArrayList();

        for (int i = 0; i < p.dsPerson.Count; i++)
        {
            person x = (person)p.dsPerson[i];
            dsPerson.Add(new person(x));
        }
    }

    // INPUT
    public void Input()
    {
        Console.Write("Nhap so nguoi: ");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhap nguoi thu " + (i + 1));

            person x = new person();
            x.Input();

            Add(x);
        }
    }

    // OUTPUT
    public void Output()
    {
        for (int i = 0; i < dsPerson.Count; i++)
        {
            Console.WriteLine("\nNguoi thu " + (i + 1));

            person x = (person)dsPerson[i];
            x.Output();
        }
    }

    // ADD
    public void Add(person x)
    {
        dsPerson.Add(x);
    }

    // LIVINGPEOPLE
    public PersonList LivingPeople()
    {
        PersonList kq = new PersonList();

        for (int i = 0; i < dsPerson.Count; i++)
        {
            person x = (person)dsPerson[i];

            if (x.IsLiving())
            {
                kq.Add(x);
            }
        }

        return kq;
    }
}

class Bai2_2
{
    static void Main()
    {
        PersonList ds = new PersonList();

        ds.Input();

        Console.WriteLine("\nDanh sach nguoi:");
        ds.Output();

        PersonList dsConSong = ds.LivingPeople();

        Console.WriteLine("\nDanh sach nguoi con song:");
        dsConSong.Output();
    }
}