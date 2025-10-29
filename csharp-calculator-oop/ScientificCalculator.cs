namespace csharp_calculator_oop
{
    public class ScientificCalculator : Calculator
    {
        public double Pow(double a, double b) 
        { 
            LastResult = Math.Pow(a, b);
            return LastResult;
        }
    }
}
