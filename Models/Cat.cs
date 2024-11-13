namespace FelineBmiCalculator.Models
{
    public class Cat
    {
        public string Name { get; set; }
        public double Weight { get; set; } // Weight in kg
        public double Length { get; set; } // Length in cm
        
        public Cat(string name, double weight, double length)
        {
            Name = name;
            Weight = weight;
            Length = length;
        }
    }
}
