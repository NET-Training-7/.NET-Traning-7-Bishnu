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

var s = ml.Greet();
Console.WriteLine(s);

var d = ml.GetDay();
Console.WriteLine(d);

float f = 12.3f, se = 45.6f, t = 67.12f;
var sum = ml.Add(f, se, t);
var tt = $"{f} + {se} + {t} = {sum}";
Console.WriteLine(tt);

