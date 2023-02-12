using System;

namespace Basics;
class DataType
{
    void LearnDataTypes()
    {

        // Numbers (Signed(+/-) and unsigned(+))
        // 1. Intrgrals
        byte a = 34;
        short b = -4235;
        ushort b1 = 63453;
        int c = 32452542;
        uint c1 = 3253225;
        long d = 3452345235325645623;
        ulong d1 = 252352353252454533;

        // 2. Floating point numbers (Prcession)
        float e = 45.56879037493275928375297509f;
        double f = 3435.5672979879888667565645653;
        decimal g = 3245.454734987538957398773598798798357m;

        // 3. Text
        char h = 'F';
        string greet = "Hello!";

        // 4. Boolean
        bool isMale = true;

        // 5. Datetime
        DateTime updatedTimeInAirport;  //camel casing
        DateOnly dob;
        TimeOnly arrivalTime;

        // Variables naming - camel casing
        // pascal casing - folders, Files, classes, methods etc.

        // Nullables
        int? score = null;
        score = 343245;
        float? x = 3453;
        x = null;

        // var
        var age = 89;
        var name = "Bishnu Rawal";
    }
}
