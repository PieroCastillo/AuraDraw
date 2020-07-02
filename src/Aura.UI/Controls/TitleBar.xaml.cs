using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Aura.UI.Controls
{
    public class TitleBar : UserControl
    {
        Button B1;
        Button B2;
        public TitleBar()
        {
            this.InitializeComponent();
            B1 = this.Find<Button>("B1");
            B2 = this.Find<Button>("B2");
            B1.Click += B1_Click;
            B2.Click += B2_Click;
        }

        protected void B2_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.OnClickInButton2();
        }

        protected void B1_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.OnClickInButton1();
        }
        #region Properties
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public string Title
        {
            get { return GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly StyledProperty<string> TitleProperty =
            AvaloniaProperty.Register<TitleBar, string>(nameof(Title), "TitleDefault");

        public object Button1Content
        {
            get { return GetValue(Button1ContentProperty); }
            set { SetValue(Button1ContentProperty, value); }
        }
        public static readonly StyledProperty<object> Button1ContentProperty =
            AvaloniaProperty.Register<TitleBar, object>(nameof(Button1Content), "1");
        public object Button2Content
        {
            get { return GetValue(Button2ContentProperty); }
            set { SetValue(Button2ContentProperty, value); }
        }
        public static readonly StyledProperty<object> Button2ContentProperty =
            AvaloniaProperty.Register<TitleBar, object>(nameof(Button2Content), "2");

        public object BoxContent
        {
            get { return GetValue(BoxContentProperty); }
            set { SetValue(BoxContentProperty, value); }
        }
        public static readonly StyledProperty<object> BoxContentProperty =
            AvaloniaProperty.Register<TitleBar, object>(nameof(BoxContent), new TextBlock() { Text = "Test" });

        public bool Button1Active
        {
            get { return GetValue(Button1ActiveProperty); }
            set { SetValue(Button1ActiveProperty, value); }
        }
        public static readonly StyledProperty<bool> Button1ActiveProperty =
            AvaloniaProperty.Register<TitleBar, bool>(nameof(Button1Active), true);

        public bool Button2Active
        {
            get { return GetValue(Button2ActiveProperty); }
            set { SetValue(Button2ActiveProperty, value); }
        }
        public static readonly StyledProperty<bool> Button2ActiveProperty =
            AvaloniaProperty.Register<TitleBar, bool>(nameof(Button2Active), true);
        #endregion

        public virtual void OnClickInButton1() { }
        public virtual void OnClickInButton2() { }
    }
}
