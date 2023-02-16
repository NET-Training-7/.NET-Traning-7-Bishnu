using System;

class Person
{
    internal string Name { get; set; }
    internal DateTime Dob { get; set; }
    internal string Natioanality { get; set; }
    public int EducationDegreeId { get; set; }

    public Person()     // Default parameterless contructor
    {
    }

    public Person(string n, DateTime a)
    {
        Name = n;
        Dob = a;
    }

    ~Person()
    {

    }
}

class EducationDegree
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Major { get; set; }
    public string University { get; set; }
}

class Test2
{
    void T()
    {
        var p1 = new Person();
        // p1.Age = 23;
        p1.Name = "Ram";

        var p2 = new Person("Kishan", DateTime.Now);
        var p3 = new Person("Kishan", DateTime.Now);
    }
}
