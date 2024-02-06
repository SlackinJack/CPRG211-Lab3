using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("This is a dog.");
        Console.Write("Enter a name: ");
        string d1 = Console.ReadLine();
        Console.Write("Enter a colour: ");
        string d2 = Console.ReadLine();
        Console.Write("Enter the age: ");
        int d3 = Convert.ToInt32(Console.ReadLine());
        Dog d = new Dog();
        d.Name = d1;
        d.Colour = d2;
        d.Age = d3;
        
        Console.WriteLine("This is a cat.");
        Console.Write("Enter a name: ");
        string c1 = Console.ReadLine();
        Console.Write("Enter a colour: ");
        string c2 = Console.ReadLine();
        Console.Write("Enter the age: ");
        int c3 = Convert.ToInt32(Console.ReadLine());
        Cat c = new Cat();
        c.Name = c1;
        c.Colour = c2;
        c.Age = c3;
        
        Console.WriteLine("Dog: " + d.Name + ", " + d.Colour + ", " + d.Age.ToString());
        d.Eat();
        Console.WriteLine("Cat: " + c.Name + ", " + c.Colour + ", " + c.Age.ToString());
        c.Eat();
    }
}
