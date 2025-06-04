using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using dont_touch_my_password.Views;

namespace dont_touch_my_password;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                // DataContext = new MainViewModel() // Supprimé car MainViewModel n'existe plus
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            /*singleViewPlatform.MainView = new MainView
            {
                // DataContext = new MainViewModel() // Supprimé car MainViewModel n'existe plus
            };*/
        }

        base.OnFrameworkInitializationCompleted();
    }
}
