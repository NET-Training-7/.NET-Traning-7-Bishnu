using System;

class MethodAssignments
{
    // 1. Method to calculate product of squares of two supplied numbers.
    int CalculateProductOfSquares(int x, int y) => (x * x) * (y * y);

    // 2. Method to calculate cuberoot of a number.
    double CalculateCubeRoot(double x) => Math.Pow(x, 1/3);

    // 3. Method to calculate BMI index of a person.
    public string CalulateBMI(float weightInKg, float heightInFeet)
    {
        float heightInMtrs = heightInFeet * 0.3048f;
        float bmi = weightInKg / (heightInMtrs * heightInMtrs);
        string message = string.Empty;

        // < 18.5 Underweight
        // >= 18.5 and <= 24.9 Normal
        // >= 25 and <= 39.9 Overweight
        // >= 40 Obese

        message = bmi switch
        {
            < 18.5f => "You are Under Weight, please eat more.",
            >= 18.5f and < 25f => "You are Normal, Congratulations!!",
            >= 25f and < 40f => "You are Over weight, Let's excercise together.",
            >= 40f => "Sorry to say but you are obese.",
            _ => "Wrong input/BMI range"
        };
        
        return message;
    }
}
