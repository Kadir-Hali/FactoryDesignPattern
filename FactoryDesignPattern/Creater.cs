namespace FactoryDesignPattern;

public class Creater
{
    public Games FactoryMethod(Games gamesType)
    {
        Games games = new Games();
        switch (gamesType)
        {
            case Games.Atari:
                games = new Games();
                break;
            case Games.PC:
                games = new Games();
                break;
            case Games.PS:
                games = new Games();
                break;
        }
        return games;
    }
}