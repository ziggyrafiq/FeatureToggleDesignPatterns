namespace FeatureToggleFactory;

public class LightThemeFactory : IUIFactory
{
    public IUIComponent CreateButton()
    {
        return new LightThemeButton();
    }
}
