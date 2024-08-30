using FeatureToggleFactory;

Console.WriteLine("Hello, from Ziggy Rafiq");

bool isFeatureA = true; 
IFeature feature = FeatureFactory.CreateFeature(isFeatureA);
feature.Execute();

bool isDarkTheme = true;
IUIFactory factory = isDarkTheme ? new DarkThemeFactory() : new LightThemeFactory();
IUIComponent button = factory.CreateButton();
button.Render();