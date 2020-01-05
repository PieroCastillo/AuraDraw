using Avalonia;
using Avalonia.Markup.Xaml;

namespace AuraDraw.App
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
