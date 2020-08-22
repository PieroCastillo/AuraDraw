using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Aura.UI.Controls;
using Aura.UI.Managers;

namespace TestControls
{
    public class App : Application
    {
        public static ILanguageManager Manager;
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            Manager = LanguageManager.Create("Languages");
            Manager.LoadSelectedLanguage("Language.theme");
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow()
                { 
                  DataContext = Manager
                };
                desktop.Exit += (sender, e) =>
                {
                    Manager.SaveSelectedLanguage("Language.theme");
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
