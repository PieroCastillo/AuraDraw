using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Layout;
using Avalonia.LogicalTree;
using Avalonia.VisualTree;
using Avalonia.Collections;
using Avalonia.Controls.Presenters;

namespace Aura.UI.Controls
{
    public class NavigationMenu : SelectingItemsControl , IContentPresenterHost
    {
        public NavigationMenu()
        {
            this.InitializeComponent();
        }

        public void RegisterContentPresenter(IContentPresenter presenter)
        {
            throw new System.NotImplementedException();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public Button MenuButton
        {
            get { return GetValue(MenuButtonProperty); }
            set { SetValue(MenuButtonProperty, value); }
        }
        public static readonly StyledProperty<Button> MenuButtonProperty =
            AvaloniaProperty.Register<NavigationMenu, Button>(nameof(MenuButton));

        public NavigationMenuState State
        {
            get { return GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        IAvaloniaList<ILogical> IContentPresenterHost.LogicalChildren => ((IContentPresenterHost)MenuButton).LogicalChildren;

        public static readonly StyledProperty<NavigationMenuState> StateProperty =
            AvaloniaProperty.Register<NavigationMenu, NavigationMenuState>(nameof(State),NavigationMenuState.Open);

        public void ToggleState()
        {
            switch (this.State) {
                case NavigationMenuState.Open : this.State = NavigationMenuState.Close;
                                                break;

                case NavigationMenuState.Close: this.State = NavigationMenuState.Open;
                    break;
            }
        }

        bool IContentPresenterHost.RegisterContentPresenter(IContentPresenter presenter)
        {
            return ((IContentPresenterHost)MenuButton).RegisterContentPresenter(presenter);
        }
    }

    public enum NavigationMenuState
    {
        Open,
        Close
    }
}
