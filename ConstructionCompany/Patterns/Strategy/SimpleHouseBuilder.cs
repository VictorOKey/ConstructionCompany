using Patterns.Builder;

namespace Patterns.Strategy;

public class SimpleHouseBuilder : IBuilder
{
    public void BuildFoundation()
    {
        Console.WriteLine("Возведён дешёвый фунтамент");
    }

    public void BuildWalls()
    {
        Console.WriteLine("Построены деревянные стены");
    }

    public void BuildRoof()
    {
        Console.WriteLine("Построена крыша из профилированного листа");
    }
}