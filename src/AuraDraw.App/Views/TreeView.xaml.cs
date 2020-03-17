using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Markup.Xaml;

namespace AuraDraw.App.Views
{
    public class TreeView : UserControl
    {
        Avalonia.Controls.TreeViewItem treeView;
        public TreeView()
        {
            this.InitializeComponent();
            treeView = this.Find<Avalonia.Controls.TreeViewItem>("tree");
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        #region Properties
        public string Title
        {
            get { return GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public readonly StyledProperty<string> TitleProperty =
            AvaloniaProperty.Register<TreeView, string>(nameof(Title), "TitleDefault");

        public IBrush TitleBrush
        {
            get { return GetValue(TitleBrushProperty); }
            set { SetValue(TitleBrushProperty, value); }
        }
        public readonly StyledProperty<IBrush> TitleBrushProperty =
            AvaloniaProperty.Register<TreeView, IBrush>(nameof(TitleBrush),Brushes.LightGreen);
        #endregion
        public void AddItem(TreeViewItem newItem , TreeViewItem owner)
        {
            owner.
        }
    }
}
