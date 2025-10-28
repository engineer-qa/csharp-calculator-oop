namespace csharp_calculator_oop;

public class Calculator
{
    public double LastResult { get; private set; }

    public double Add (double a, double b)
    {
        LastResult = a + b;
        return LastResult;
    }

    public double Subtract(double a, double b)
    {
        LastResult = a - b;
        return LastResult;
    }

    public double Multiply(double a, double b)
    {
        LastResult = a * b;
        return LastResult;
    }

    public double Divide(double a, double b)
    {
        LastResult = a / b;
        return LastResult;
    }
}
