using System;

class Loop
{
    void LearnLoops()
    {
        // Loops/Iterations: for, while, do-while, foreach

        for (var counter = 0; counter < 100; counter++)
        {
            Console.Write(counter + 1 + " ");
        }

        var counter1 = 0;
        while (counter1 < 100)
        {
            // code
            Console.Write(counter1 + 1 + " ");
            counter1++;
        }

        string key = "y";
        while (key == "y")
        {
            Console.WriteLine("Hello");
            Console.Write("Greet again? ");
            key = Console.ReadLine();
        }

        string[] names = { "Ram", "Shyam", "Hari", "Gita" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }
}