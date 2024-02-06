using System;

public class Cat : IAnimal {
    private string n;
    private string c;
    private int h;
    private int a;
    public string Name {get {return this.n;} set{this.n = value;}}
    public string Colour {get {return this.c;} set{this.c = value;}}
    public int Height {get {return this.h;} set{this.h = value;}}
    public int Age {get {return this.a;} set{this.a = value;}}
    public void Eat() {
        Console.WriteLine("Cats eat mice.");
    }
    public string Cry() {
        return "Meow!";
    }
}
