// Parallel Programming
// Multthreading - Creating threads manually
// Tasks - Task Parallel Library(TPL)
// Requirements: 
// Computation for each item should be independent
// Each computation takes some time (>200ms)

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class ParallelProgramming
{
    double[] numbers = { 3.5, 6.7, 21.3, 45.6, 23.1, 22.56, 89.01, 44.56, 67.34, 67.123 };

    public void ComputeSquareRoots()
    {
        // Sequential
        Stopwatch sw = Stopwatch.StartNew();
        Console.WriteLine("Sequential Version:");
        foreach (var num in numbers)
        {
            CalulateSR(num);
        }
        Console.WriteLine($"It took:{sw.ElapsedMilliseconds} ms.");

        // Prallel
        sw.Restart();
        Console.WriteLine("Parallel Version:");
        Parallel.ForEach(numbers, (num) =>
        {
            CalulateSR(num);
        });
        Console.WriteLine($"It took:{sw.ElapsedMilliseconds} ms.");
    }

    void CalulateSR(double num)
    {
        //Thread.Sleep(10);
        var sq = Math.Sqrt(num);
        Console.WriteLine($"Square root of {num} is {sq}");
    }
}

// Asynchronous Programming
// AJAX - Asynchronous JavaScript And XML
// C# - Non-blocking IO, async await
class AsyncProgramming
{
    public async Task<bool> Calulate()
    { 
        await Calulate1();
        await Calulate2();
        await Calulate3();
        return true;
    }

    public async Task Calulate1()
    {        
        await Task.Delay(1000);
    }

    public async Task Calulate2()
    {        
        await Task.Delay(1000);
    }

    public async Task Calulate3()
    {        
        await Task.Delay(1000);
    }
}
