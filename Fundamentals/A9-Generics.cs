using System;

class Generics<Y>
{
    public void Print<X>(X x)
    {
        Console.WriteLine($"Printing given argument: {x}");
    }    

    public void Greet(Y message)
    {
        Console.WriteLine(message);
    }
}

