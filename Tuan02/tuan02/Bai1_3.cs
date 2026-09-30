using System;

class Person
{
    // field
    private int id;
    private string name;
    private int yob;
    private int yod;

    //constructor mac dinh
    public Person()
    {
        id = 0;
        name = "";
        yob = 0;
        yod = 0;
    }

    // constructor co tham so
    public Person(Person p)
    {
        this.id = p.id;
        this.name = p.name;
        this.yob = p.yob;
        this.yod = p.yod;
    }

    // property
    public int Id
    {
        get{return id;}
        set{id= value;}
    }

    public string Name
    {
        get {return name;}
        set {name=value;}
    }

    public int Yob
    {
        get{return yob;}
        set {yob=value;}
    }

    public int Yod
    {
        get {return yod;}
        set {yod=value;}
    }

    // method nhap
    public void Input()
    {
        Console.Write("nhap id: ");
        id = int.Parse(Console.ReadLine()!);

        Console.Write("nhap ten: ");
        name = Console.ReadLine()!;

        Console.Write("nhap nam sinh: ");
        yob = int.Parse(Console.ReadLine()!);

        Console.Write("nhap nam mat (0 neu con song): ");
        yod = int.Parse(Console.ReadLine()!);
    }

    // method xuat
    public void Output()
    {
        Console.WriteLine("ID:" +id);
        Console.WriteLine("ten:" +name);
        Console.WriteLine("nam sinh:" +yob);
        Console.WriteLine("nam mat:" +yod);
    }

    // Method IsLiving
    public bool IsLiving()
    {
        if (yod == 0)
            return true;
        else
            return false;
    }
}
class Bai1_3
{
     static void Main()
    {
        Person p = new Person();
        p.Input();

        Console.WriteLine("\nthong tin:");
        p.Output();

        if (p.IsLiving())
            Console.WriteLine("Trang thai: Con song");
        else
            Console.WriteLine("Trang thai: Da mat");
    }
}