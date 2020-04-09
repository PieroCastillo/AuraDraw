using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Aura.UI.Controls
{
    public class TitleControl : UserControl
    {
        public TitleControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public string Title
        {
            get { return GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public readonly StyledProperty<string> TitleProperty =
            AvaloniaProperty.Register<TitleControl, string>(nameof(Title), "Title");

        public IBrush TitleBrush
        {
            get { return GetValue(TitleBrushProperty); }
            set { SetValue(TitleBrushProperty, value); }
        }
        public readonly StyledProperty<IBrush> TitleBrushProperty =
            AvaloniaProperty.Register<TitleControl, IBrush>(nameof(TitleBrush), Brushes.LightGreen);
    }
}
