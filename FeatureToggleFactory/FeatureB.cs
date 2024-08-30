namespace FeatureToggleFactory;

public class FeatureB : IFeature
{
    public void Execute()
    {
        Console.WriteLine("Feature B executed.");
    }
}
