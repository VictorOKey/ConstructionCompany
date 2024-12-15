using Patterns.Builder;

namespace Patterns.Strategy;

public class LuxuryHouseBuilder : IBuilder
{
    public void BuildFoundation()
    {
        Console.WriteLine("Возведён дорогой фундамент");
    }

    public void BuildWalls()
    {
        Console.WriteLine("Построены кирпичные стены");
    }

    public void BuildRoof()
    {
        Console.WriteLine("Построена крыша из мягкой черепицы");
    }
}