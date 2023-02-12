namespace Inheritance;
class ElectricVehicle: Vehicle
{
    public ElectricVehicle(string type, 
        string model,
        string vendor, 
        byte wheels, 
        float mileage, 
        string vNumber) : 
            base(type: type, 
                wheels: wheels, 
                mileage: mileage, 
                vNumber: vNumber, 
                vendor: vendor, 
                model: model)
    {
        
    }
    
    float batteryCapacityInKw; 

    float CalculateEnginePowerHP() => batteryCapacityInKw * 1.369f; 
}
