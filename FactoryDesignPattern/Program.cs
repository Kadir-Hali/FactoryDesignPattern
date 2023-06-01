using FactoryDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        Creater creater = new Creater();
        Games atariOyunu = creater.FactoryMethod(Games.Atari);
        Games pcOyunu = creater.FactoryMethod(Games.PC);
        Games psOyunu = creater.FactoryMethod(Games.PS);

        atariOyunu = Games.Atari;
        pcOyunu = Games.PC;
        psOyunu = Games.PS;

        Console.Read();
    }
}