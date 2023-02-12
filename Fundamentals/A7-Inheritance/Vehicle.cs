using System;

namespace Inheritance;
abstract class Vehicle
{
    internal string vendor;
    internal string vehicleNumber;
    internal string model;
    internal string type;
    internal byte nWheels;
    internal float mileage;

    public Vehicle(string type, 
        string model,
        string vendor, 
        byte wheels, 
        float mileage, 
        string vNumber)
    {
        this.type = type;
        this.model = model;
        this.vendor = vendor;
        this.vehicleNumber = vNumber;
        this.mileage = mileage;
        this.nWheels = wheels;
    }

    internal virtual void PrintDetails()
    {
        var vDetails = $"It's {nWheels} wheeler {model} {type} from {vendor} and " +
            $"vehicle code is {vehicleNumber}. " +
            $"This {type} has claimed mileage of {mileage} km/l.";
        Console.Write(vDetails);
    }
}
