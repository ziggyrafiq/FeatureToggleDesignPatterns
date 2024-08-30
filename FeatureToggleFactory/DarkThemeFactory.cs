namespace FeatureToggleFactory;

public class DarkThemeFactory : IUIFactory
{
    public IUIComponent CreateButton()
    {
        return new DarkThemeButton();
    }
}

