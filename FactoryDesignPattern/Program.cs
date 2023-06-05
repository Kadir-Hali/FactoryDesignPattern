using FactoryDesignPattern;

public class Program
{
    private static void Main(string[] args)
    {
        CalculateFactory calculateFactory = new CalculateFactory();
        ICalculator calculator = calculateFactory.CreateCalculation("Çarpma");
        calculator.Calculate();
    }
}