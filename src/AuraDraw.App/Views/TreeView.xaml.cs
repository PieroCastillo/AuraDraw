using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Markup.Xaml;
using AuraDraw.App.Functions;
using Avalonia.Collections;
using System.Collections;

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
            AvaloniaProperty.Register<TreeView, IBrush>(nameof(TitleBrush), Brushes.LightGreen);
        #endregion
        
        public void NewCollectionOfItems(Document document)
        {
            AvaloniaList<TreeViewItem> Items = new AvaloniaList<TreeViewItem>(); //new temporal list to add
            AvaloniaList<TreeViewItem> Items1 = new AvaloniaList<TreeViewItem>();
            foreach (Item item in document.Items)
            {
                var tview = new TreeViewItem() //Create a new TreeViewItem for each item in document.Items
                {
                    Header = item.Header,
                    Items = item.Items
                };
                 
                foreach (Item nitem in item)
                {
                    var t1view = new TreeViewItem() 
                    {
                        Header = nitem.Header,
                        Items = nitem.Items
                    };
                    Items1.Add(t1view);
                }
                tview.Items = Items1;
                Items.Add(tview); //add a new treeviewitems created the last sentences to the temporal list
            }
            treeView.Items = Items; //add the temporal list to the TreeViewItemList
        }
    }
}
