using System;

// Top-level statements
// public static void Main() is implicitly there

MethodLearner ml = new();
// ml.Display();
// ml.Display("Hi");
// ml.Display("Welcome");
// ml.Display();

// ml.Add(34.3f, 56.5f);
// ml.Add(3445.3345f, 123.345f);
// ml.Add(123124.3f, 756.798f);

// var s = ml.Greet();
// Console.WriteLine(s);

// var d = ml.GetDay();
// Console.WriteLine(d);

// float f = 12.3f, se = 45.6f, t = 67.12f;
// var sum = ml.Add(f, se, t);
// var tt = $"{f} + {se} + {t} = {sum}";
// Console.WriteLine(tt);

// var p = ml.Multiply(34.5, 67.7, 45.12);
// var p1 = ml.Multiply(34.5, 67.7);

// var p2 = ml.SumOfSquares(34.5, 3, 4, 5, 6, 7);
// var p3 = ml.SumOfSquares(34.5, 3, 4, 5, 6, 7, 4, 4, 6, 7, 8, 8, 3, 3, 6, 67, 78);

// // Named arguments
// var p5 = ml.Multiply(z: 34.5, x: 67.7, y: 45.12);

var x = ml.CalculateMin(3, 4, 5, 6, 7, 8, 12, 98, 2, 45, -1);
var (min, max) = ml.CalculateMinMax(3, 4, 5, 6, 7, 8, 12, 98, 2, 45, -1);
