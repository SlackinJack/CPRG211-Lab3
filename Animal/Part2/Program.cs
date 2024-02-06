using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("This is a dog.");
        Console.Write("Enter a name: ");
        string d1 = Console.ReadLine();
        Console.Write("Enter a colour: ");
        string d2 = Console.ReadLine();
        Console.Write("Enter the height: ");
        int d3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the age: ");
        int d4 = Convert.ToInt32(Console.ReadLine());
        Dog d = new Dog();
        d.Name = d1;
        d.Colour = d2;
        d.Height = d3;
        d.Age = d4;
        
        Console.WriteLine("This is a cat.");
        Console.Write("Enter a name: ");
        string c1 = Console.ReadLine();
        Console.Write("Enter a colour: ");
        string c2 = Console.ReadLine();
        Console.Write("Enter the height: ");
        int c3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the age: ");
        int c4 = Convert.ToInt32(Console.ReadLine());
        Cat c = new Cat();
        c.Name = c1;
        c.Colour = c2;
        c.Height = c3;
        c.Age = c4;

        Console.WriteLine("Dog: " + d.Name + ", " + d.Colour + ", " + d.Height.ToString() + ", " + d.Age.ToString());
        d.Eat();
        Console.WriteLine(d.Cry());
        Console.WriteLine("Cat: " + c.Name + ", " + c.Colour + ", " + c.Height.ToString() + ", "  + c.Age.ToString());
        c.Eat();
        Console.WriteLine(c.Cry());
    }
}
