using Patterns.Builder;
using Patterns.Strategy;
using Patterns.Singleton;

class Program
{
    static void Main(string[] args)
    {
        ConstructionCompany company = ConstructionCompany.GetInstance();

        IBuilder simpleHouseBuilder = new SimpleHouseBuilder();
        IBuilder luxuryHouseBuilder = new LuxuryHouseBuilder();

        company.BuildHouse(simpleHouseBuilder);
        Console.WriteLine("----------------------");
        company.BuildHouse(luxuryHouseBuilder);
    }
}