using System;

class MethodLearner
{
    // Method that returns nothing, takes no arguments
    public void Display()
    {
        Console.WriteLine("Hello guys, I am simplest possible method in C#.");       
    }

    // Returns nothing, takes some arguments
    // Method overloading (Polymorphism - OOP)
    public void Display(string greeting)
    {
        Console.WriteLine($"{greeting} guys, I am simplest possible method in C#.");       
    }

    public void Add(float first, float second)
    {
        float sum = first + second;
        string dText = $"{first} plus {second} equals {sum}";     // String interpolation

        Console.WriteLine(dText);  //3 + 7 = 10
    }

    // Returns something, takes no arguments
    public string Greet()
    {
        string text = "Hi guys, I am simplest possible method in C#.";
        return text;       
    }

    public string GetDay()
    {
        var d = DateTime.Today.DayOfWeek.ToString();
        string today = $"It's {d}";
        return today;  
    }

    // Returns something, takes some arguements
    public float Add(float first, float second, float third)
    {
        float sum = first + second + third;
        return sum;
    }        
}
