using System;

internal class House
{
    internal string address; // Access Modifiers: Private, public, internal, protected 
    internal float length;
    internal float width;
    internal float area;

    internal void GetArea()
    {
        area = length * width;
    }
}
