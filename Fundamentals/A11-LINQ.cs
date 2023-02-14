// LINQ - Language Integrated Query
// Technique to query collections (Array, List, dictionaries etc.)

using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] scores = { 3, 4, 5, 6, 12, 34, 15, 230, 56, 13, 870, 98, 93, 231, 342 };
    string[] names = { "Ram Karki", "ELton John", "Balen Shah", "Baburam Bhattarai" };

    public void LearnToQuery()
    {
        // Q1. Find all even numbers from scores
        // Method syntax
        var evenNumbers = scores.Where(s => s % 2 == 0);

        // Expression syntax
        evenNumbers = from s in scores
                      where s % 2 == 0
                      select s;

        // Q2. Find all odd numbers from scores
        var oddNumbers = scores.Where(s => s % 2 != 0);

        // Q3. Find multiples of 3 and 5 from scores
        var multiplesOf3And5 = scores.Where(s => s % 3 == 0 && s % 5 == 0);

        // Q4. Find squares of all numbers in scores
        var squares = scores.Select(s => s * s);

        // Q5. Find squares of all numbers which are less than 50 from scores
        var squaresLessThan50 = scores.Where(s => s < 50).Select(s => s * s);

        squaresLessThan50 = from s in scores
                            where s < 50
                            select s * s;

        // Q6. Find cubes of all numbers in between 50 and 70 from scores
        // Q7. Find square roots of all numbers ending in 0 from scores
        // Q8. Get uppercase equivalent of all names and sort them in ascending order
        var uNames = from name in names
                     orderby name
                     select name.ToUpper(); 

        foreach (var num in squares)
        {
            Console.Write($"{num} ");
        }
    }
}
