namespace csharp_calculator_oop
{
    public class ScientificCalculator : Calculator
    {
        public override double Divide(double a, double b)
        {
            Console.WriteLine($"Override Logs => Deviding {a} by {b}");
            return base.Divide(a, b);
        }
        public double Pow(double a, double b) 
        { 
            LastResult = Math.Pow(a, b);
            return LastResult;
        }
    }
}
