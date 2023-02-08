class Person
{
    internal string name;
    internal byte age;

    public Person()     // Default parameterless contructor
    {        
    }

    public Person(string n, byte a)
    {
        name = n;
        age = a;
    }

    ~Person()
    {

    }
}

class Test2
{
    void T()
    {
        var p1 = new Person();
        p1.age = 23;
        p1.name = "Ram";
        
        var p2 = new Person("Kishan", 67);
        var p3 = new Person("Kishan", 67);
    }
}
