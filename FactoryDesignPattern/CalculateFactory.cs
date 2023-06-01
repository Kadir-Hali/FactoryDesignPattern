namespace FactoryDesignPattern;

public class CalculateFactory
{
    public ICalculator CreateCalculation(string operationName)
    {
        if (String.IsNullOrEmpty(operationName))
        {
            return null;
        }
        if ("Toplama".Equals(operationName))
        {
            return new Plus();
        }
        if ("Çıkarma".Equals(operationName))
        {
            return new Minus();
        }
        if ("Çarpma".Equals(operationName))
        {
            return new Multiplication();
        }
        return null;
    }
}