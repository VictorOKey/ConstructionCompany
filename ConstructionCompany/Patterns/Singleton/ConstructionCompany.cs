using Patterns.Builder;

namespace Patterns.Singleton;

public class ConstructionCompany
{
    private static ConstructionCompany instance;

    private ConstructionCompany() { }
    
    public static ConstructionCompany GetInstance()
    {
        if (instance == null)
        {
            instance = new ConstructionCompany();
        }
        return instance;
    }
    
    public void BuildHouse(IBuilder builder)
    {
        builder.BuildFoundation();
        builder.BuildWalls();
        builder.BuildRoof();
    }
}