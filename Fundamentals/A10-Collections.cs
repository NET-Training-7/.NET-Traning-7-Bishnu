using System.Collections.Generic;

class Collections
{
    void LearnList()
    {
        int[] numbers = { 34, 56, 12, 45 };

        List<int> numList = new List<int>() { 34, 56, 12, 45 };
        numList.Add(78);
        numList.Remove(56);


        List<Person> people = new List<Person>();
        
        var p1 = new Person() { Name = "Bishnu" };
        people.Add(p1);
        people.Add(new Person() { Name = "Ram" });
        people.Add(new Person() { Name = "Hari" });
        people.Add(new Person() { Name = "Bishnu" });
        people.Remove(new Person() { Name = "Ram" });
    }

    void LearnDictionary()
    {
        // Store country and its capital
        Dictionary<string, string> countryCapitals = new();
        countryCapitals.Add("Nepal", "Kathmandu");
        countryCapitals.Add("India", "Delhi");
        countryCapitals.Add("China", "Kathmandu");

        // Classwork: Create a datastructure to store district and its population

    }

    void LearnOthers()
    {
        Stack<string> plates = new();   //LIFO
        plates.Push("Plate1");
        plates.Push("Plate2");
        plates.Push("Plate3");
        plates.Push("Plate4");
        plates.Push("Plate5");
        plates.Pop();

        Queue<string> manchhekoline = new Queue<string>();  //FIFO
        manchhekoline.Enqueue("person1"); 
        manchhekoline.Enqueue("person2"); 
        manchhekoline.Enqueue("person3"); 
        manchhekoline.Enqueue("person4"); 
        manchhekoline.Enqueue("person5");
        manchhekoline.Dequeue();
    }
}
