using System;

namespace Basics;
public class Phone
{
    string brand;
    public string Brand
    {
        get
        {
            return brand;
        }
        set
        {
            if (value.Length > 1)
            {
                brand = value;
            }
        }
    }

    DateTime releaseDate;
    public DateTime ReleaseDate
    {
        get
        {
            return releaseDate;
        }
        set
        {
            if (value < DateTime.Now)   // Past date
            {
                releaseDate = value;
            }
        }
    }

    // Auto-implemented property
    public string Model { get; set; }

    // Read-only property
    public string ChipManufacturer { get; }
    
    public string Storage { get; private set;}
    
    public static string material = "Almunium";
    public static void PrintDetails()
    {        
        Console.WriteLine($"It's all about phones. I am made of {material}");
    }
}
