using FelineBmiCalculator.Models;

namespace FelineBmiCalculator.Services
{
    public static class BmiCalculator
    {
        // Formula: BMI = weight (kg) / length² (m²)
        public static double CalculateBmi(Cat cat)
        {
            double lengthInMeters = cat.Length / 100; // Convert length to meters
            return cat.Weight / (lengthInMeters * lengthInMeters);
        }
    }
}
