using System;

class Conditionals
{
    void LearnConditionals()
    {
        // Conditionals 
        Console.Write("Enter your age:");
        string age = Console.ReadLine();
        int x = int.Parse(age);

        if (x < 18)
        {
            Console.WriteLine("You are underage.");
        }
        else if (x < 45)
        {
            Console.WriteLine("You are adult now.");
        }
        else
        {
            Console.WriteLine("You are in your old age.");
        }

        // Print greetings for different grades: A+, A, A-, B+ etc.
        string grade = "A+";

        if (grade == "A+")
        {
            Console.WriteLine("Excellant! you got above 90%.");
        }
        else if (grade == "A")
        {
            Console.WriteLine("Excellant! you got between 80-90%.");
        }
        else if (grade == "A-")
        {
            Console.WriteLine("Excellant! you got btween 70-80%.");
        }
        else
        {
            Console.WriteLine("Good job! try harder!.");
        }


        switch (grade)
        {
            case "A+":
                Console.WriteLine("Excellant! you got above 90%.");
                break;

            case "A":
                Console.WriteLine("Excellant! you got between 80-90%.");
                break;

            case "A-":
                Console.WriteLine("Excellant! you got between 70-80%.");
                break;

            default:
                Console.WriteLine("Good job! try harder!.");
                break;
        }

    }
}