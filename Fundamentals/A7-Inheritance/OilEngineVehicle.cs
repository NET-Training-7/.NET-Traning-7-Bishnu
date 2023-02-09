
using System;

class OilEngineVehicle : Vehicle
{
    public OilEngineVehicle(string type, 
        string model,
        string vendor, 
        byte wheels, 
        float mileage, 
        string vNumber,
        float cc) : 
            base(type: type, 
                wheels: wheels, 
                mileage: mileage, 
                vNumber: vNumber, 
                vendor: vendor, 
                model: model)
    {
        engineCapacityInCC = cc;
    }

    internal float engineCapacityInCC;
    internal float CalculateEnginePowerHP() => engineCapacityInCC / 32.2f;
    
    internal override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($" Engine power of this vehicle is {CalculateEnginePowerHP()}");
    }
}
