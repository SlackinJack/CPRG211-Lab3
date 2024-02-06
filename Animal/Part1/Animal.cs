public abstract class Animal {
    private string n;
    private string c;
    private int a;

    public string Name {
        get {return this.n;}
        set {this.n = value;}
    }
    
    public string Colour {
        get {return this.c;}
        set {this.c = value;}
    }
    
    public int Age {
        get {return this.a;}
        set {this.a = value;}
    }
    
    public abstract void Eat();
}
