namespace FeatureToggleFactory;

public class FeatureFactory
{
    public static IFeature CreateFeature(bool isFeatureA)
    {
        return isFeatureA ? new FeatureA() : new FeatureB();
    }
}
