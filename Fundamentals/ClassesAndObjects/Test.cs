using System;

class Test
{
    internal void Foo()
    {
        House house1 = new();
        var house2 = new House();

        house1.address = "Tinkune, Ktm";
        house1.length = 45.6f;
        house1.width = 25.3f;
        house1.GetArea();
        Console.WriteLine(house1.area);
    }
}
