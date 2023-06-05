namespace FactoryDesignPattern;

public class Plus : ICalculator
{
    public void Calculate()
    {
        Console.WriteLine("Toplama işlemi yapılıyor.");
    }
}