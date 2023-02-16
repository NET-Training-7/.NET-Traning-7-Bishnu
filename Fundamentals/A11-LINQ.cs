// LINQ - Language Integrated Query
// Technique to query collections (Array, List, dictionaries etc.)

using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] scores = { 3, 4, 5, 6, 12, 34, 15, 230, 56, 13, 870, 98, 93, 231, 342 };
    string[] names = { "Ram Karki", "ELton John", "Balen Shah", "Baburam Bhattarai" };
    Dictionary<string, long> countryPopulation = new()
    {
        ["Nepal"] = 9837498,
        ["India"] = 127398217498,
        ["China"] = 123802342434,
        ["USA"] = 3802342434,
        ["Germany"] = 22342434,
        ["Canada"] = 12342434
    };
    List<Person> people = new()
    {
        new Person(){EducationDegreeId=1, Natioanality="Nepal", Name = "Ram Ji", Dob = new DateTime(1998, 12, 13)},
        new Person(){EducationDegreeId=2, Natioanality="China", Name = "Ajaya", Dob = new DateTime(2010, 1, 13)},
        new Person(){EducationDegreeId=3, Natioanality="India", Name = "Krishna", Dob = new DateTime(1988, 2, 23)},
        new Person(){EducationDegreeId=3, Natioanality="USA", Name = "Anirudra", Dob = new DateTime(1978, 3, 1)},
        new Person(){EducationDegreeId=1, Natioanality="India", Name = "Kishan", Dob = new DateTime(1990, 4, 13)},
        new Person(){EducationDegreeId=2, Natioanality="Nepal", Name = "Roshan", Dob = new DateTime(2008, 10, 29)},
    };

    List<EducationDegree> degrees = new()
    {
        new() { Id = 1, Major = "Science", Title = "M.Sc.", University = "TU"},
        new() { Id = 2, Major = "Arts", Title = "M.A.", University = "KU"},
        new() { Id = 3, Major = "Education", Title = "M.Ed.", University = "TU"}
    };

    public void LearnToQuerySelectAndWhere()
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


        // List all country names
        // List all countries in descending order of their population

        var countryNames = countryPopulation.Select(c => c.Key);
        var countriesSorted = from c in countryPopulation
                              orderby c.Value
                              select c;

        foreach (var num in squares)
        {
            Console.Write($"{num} ");
        }
    }
    public void LearnToQueryOthers()
    {
        // Quntification: Any, All
        // Find if scores contains any even number
        var containEvenNumber = scores.Any(x => x % 2 == 0);
        var containAnyElement = scores.Any();

        // Find if scores has all even numbers
        var allEvenNumbers = scores.All(x => x % 2 == 0);

        // Partitioning: skip and take
        // Get first 3 elements from scores
        var x = scores.Take(3);

        // Skip frist 5 and take next 3
        var y = scores.Skip(5).Take(3);
    }
    public void LearnTOQueryComplexCollections()
    {
        // Find names of people who can vote
        // fix this
        var voteList = from p in people
                       where ((DateTime.Now - p.Dob).TotalDays / 365) >= 18
                       select p.Name;

        // Find all nepalese people who born after .NET is released
        var z = from p in people
                where p.Natioanality == "Nepal" && p.Dob.Year > 2002
                select p;

        // Find all people names and corresponding degree title who has science major
        // Find all indians who are doing arts. Print all people and their education details. 

    }
}
