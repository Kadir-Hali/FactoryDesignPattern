namespace FactoryDesignPattern;

internal class Plus : ICalculator
{
    public void Calculate()
    {
        Console.WriteLine("Toplama işlemi yapılıyor.");
    }
}