namespace FeatureToggleFactory;

public class FeatureA : IFeature
{
    public void Execute()
    {
        Console.WriteLine("Feature A executed.");
    }
}
