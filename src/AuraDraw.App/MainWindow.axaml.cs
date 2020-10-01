using Aura.UI.Controls;
using Aura.UI.UIExtensions;
using AuraDraw.App.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using Avalonia.Input;
using Aura.CommonCore.IO;

namespace AuraDraw.App
{
    public class MainWindow : Window
    {
        #region MenuItems
        MenuItem NewDocument;
        MenuItem OpenDocument; //= this.Find<MenuItem>("open_file_btn" 
        MenuItem SaveDocument; //= this.Find<MenuItem>("save_file_btn" 
        MenuItem OpenHomePage; // "open_home_page_btn"
        MenuItem SaveDocumentAs; //= this.Find<MenuItem>("save_as_file_btn" 
        MenuItem CloseFile; //= this.Find<MenuItem>("close_file_btn""Salir" 
        MenuItem CloseApp; //= this.Find<MenuItem>("exit_app_btn"
        MenuItem CopySelected; // = this.Find<MenuItem>("copy_obj_btn" 
        MenuItem Paste;//Name="paste_obj_btn" 
        MenuItem Double; // = this.Find<MenuItem>("duplicate_obj_btn" 
        MenuItem Eliminar; // = this.Find<MenuItem>("delete_obj_btn" 
        MenuItem ReDo; // = this.Find<MenuItem>("redo_btn" 
        MenuItem UnDo; // = this.Find<MenuItem>("undo_btn" 
        MenuItem HistorialDeshacer; // = this.Find<MenuItem>("undo_historial_btn" 
        MenuItem Select; // = this.Find<MenuItem>("select_btn" 
        MenuItem SelectAll; // = this.Find<MenuItem>("select_all_btn" 
        MenuItem InvertSelected; // = this.Find<MenuItem>("invert_selected_btn" 
        MenuItem UnSelect; // = this.Find<MenuItem>("deselect_selected_btn" 
        MenuItem DeleteThingSelected; // = this.Find<MenuItem>("delete_selected_btn" 
        MenuItem ZoomTo10; // = this.Find<MenuItem>("10_zoom_btn" 
        MenuItem ZoomTo50; // = this.Find<MenuItem>("50_zoom_btn" 
        MenuItem ZoomTo100; // = this.Find<MenuItem>("100_zoom_btn" 
        MenuItem ZoomTo150; // = this.Find<MenuItem>("150_zoom_btn" 
        MenuItem ZoomTo200; // = this.Find<MenuItem>("200_zoom_btn"
        MenuItem ObjectsView; // = this.Find<MenuItem>("view_objs_btn"
        MenuItem ObjectsBox; // = this.Find<MenuItem>("square_objs_btn"
        MenuItem FullScreenView; // = this.Find<MenuItem>("fullscreen_view_btn"
        MenuItem Group; // = this.Find<MenuItem>("grup_obj_btn"
        MenuItem UnGroup; // = this.Find<MenuItem>("ungrup_obj_btn"
        MenuItem Fill; // = this.Find<MenuItem>("fill_obj_btn"
        MenuItem Up; // = this.Find<MenuItem>("move_up_obj_btn"
        MenuItem Down; // = this.Find<MenuItem>("move_down_obj_btn"
        MenuItem BringObjectToStart; // = this.Find<MenuItem>("trans_start_obj_btn"
        MenuItem BringObjectToEnd; // = this.Find<MenuItem>("trans_end_obj_btn"
        MenuItem RotateObject90ToRight; // = this.Find<MenuItem>("rote_90_right_obj_btn"
        MenuItem RotateObject90ToLeft; // = this.Find<MenuItem>("rote_90_left_obj_btn"
        MenuItem DeleteObject; // = this.Find<MenuItem>("del_obj_btn"
        MenuItem NewLayout; // = this.Find<MenuItem>("new_cap_btn"
        MenuItem RenameLayout; // = this.Find<MenuItem>("rename_cap_btn"
        MenuItem HideLayout; // = this.Find<MenuItem>("hide_cap_btn"
        MenuItem LockLayout; // = this.Find<MenuItem>("lock_cap_btn"
        MenuItem CarryLayoutUp; // = this.Find<MenuItem>("move_up_cap_btn"
        MenuItem CarryLayoutDown; // = this.Find<MenuItem>("move_down_cap_btn"
        MenuItem BringTotheStartLayout; // = this.Find<MenuItem>("trans_top_cap_btn" 
        MenuItem BringTotheFinalLayout; //Name = "trans_bottom_cap_btn"
        MenuItem EliminarCapa; // = this.Find<MenuItem>("delete_cap_btn"
        MenuItem InsertarTexto; // = this.Find<MenuItem>("insert_text_btn" 
        MenuItem OpenSettings; // Name="settings_btn" 
        MenuItem Minimizar; // = this.Find<MenuItem>("minimize_btn"
        MenuItem Maximizar; // = this.Find<MenuItem>("maximize_btn"
        MenuItem OpenOnGithub; // = this.Find<MenuItem>("github_btn"
        MenuItem AboutAuraDraw; // = this.Find<MenuItem>("about_of_btn" 
#endregion
        public MainWindow()
        {
            InitializeComponent();
            this.Icon = new WindowIcon(new Bitmap(@"Assets/Logo.png"));
#if DEBUG 
            this.AttachDevTools();
#endif
            #region Initialize MenuItems
            NewDocument = this.Find<MenuItem>("new_file_btn"); 
        OpenDocument = this.Find<MenuItem>("open_file_btn");
            OpenHomePage = this.Find<MenuItem>("open_home_page_btn");
        SaveDocument = this.Find<MenuItem>("save_file_btn"); 
        SaveDocumentAs = this.Find<MenuItem>("save_as_file_btn"); 
        CloseFile = this.Find<MenuItem>("close_file_btn");
        CloseApp = this.Find<MenuItem>("exit_app_btn");
        CopySelected = this.Find<MenuItem>("copy_obj_btn"); 
        Paste = this.Find<MenuItem>("paste_obj_btn" );
        Double = this.Find<MenuItem>("duplicate_obj_btn"); 
        Eliminar = this.Find<MenuItem>("delete_obj_btn" );
        ReDo = this.Find<MenuItem>("redo_btn" );
        UnDo = this.Find<MenuItem>("undo_btn" );
        HistorialDeshacer = this.Find<MenuItem>("undo_historial_btn" );
        Select = this.Find<MenuItem>("select_btn" );
        SelectAll = this.Find<MenuItem>("select_all_btn"); 
        InvertSelected = this.Find<MenuItem>("invert_selected_btn"); 
        UnSelect = this.Find<MenuItem>("deselect_selected_btn" );
        DeleteThingSelected = this.Find<MenuItem>("delete_selected_btn"); 
        ZoomTo10 = this.Find<MenuItem>("10_zoom_btn" );
        ZoomTo50 = this.Find<MenuItem>("50_zoom_btn" );
        ZoomTo100 = this.Find<MenuItem>("100_zoom_btn" );
          ZoomTo150 = this.Find<MenuItem>("150_zoom_btn" );
          ZoomTo200 = this.Find<MenuItem>("200_zoom_btn" );
          ObjectsView = this.Find<MenuItem>("view_objs_btn"); 
          ObjectsBox = this.Find<MenuItem>("square_objs_btn"); 
          FullScreenView = this.Find<MenuItem>("fullscreen_view_btn"); 
          Group = this.Find<MenuItem>("grup_obj_btn" );
          UnGroup = this.Find<MenuItem>("ungrup_obj_btn"); 
          Fill = this.Find<MenuItem>("fill_obj_btn" );
          Up = this.Find<MenuItem>("move_up_obj_btn");
          Down = this.Find<MenuItem>("move_down_obj_btn"); 
          BringObjectToStart = this.Find<MenuItem>("trans_start_obj_btn"); 
          BringObjectToEnd = this.Find<MenuItem>("trans_end_obj_btn" );
          RotateObject90ToRight = this.Find<MenuItem>("rote_90_right_obj_btn");
          RotateObject90ToLeft = this.Find<MenuItem>("rote_90_left_obj_btn");
          DeleteObject = this.Find<MenuItem>("del_obj_btn" );
          NewLayout = this.Find<MenuItem>("new_cap_btn" );
          RenameLayout = this.Find<MenuItem>("rename_cap_btn"); 
          HideLayout = this.Find<MenuItem>("hide_cap_btn" );
          LockLayout = this.Find<MenuItem>("lock_cap_btn" );
          CarryLayoutUp = this.Find<MenuItem>("move_up_cap_btn"); 
          CarryLayoutDown = this.Find<MenuItem>("move_down_cap_btn"); 
          BringTotheStartLayout = this.Find<MenuItem>("trans_top_cap_btn");
          BringTotheFinalLayout = this.Find<MenuItem>("trans_bottom_cap_btn");
          EliminarCapa = this.Find<MenuItem>("delete_cap_btn" );
          InsertarTexto = this.Find<MenuItem>("insert_text_btn" );
          OpenSettings = this.Find<MenuItem>("settings_btn" );
          Minimizar = this.Find<MenuItem>("minimize_btn" );
          Maximizar = this.Find<MenuItem>("maximize_btn" );
          OpenOnGithub = this.Find<MenuItem>("github_btn" );
          AboutAuraDraw = this.Find<MenuItem>("about_of_btn");
            #endregion

            #region OnClickMenuItems
            NewDocument.Click += NewDocument_Click;
            OpenHomePage.Click += OpenHomePage_Click;

            SaveDocumentAs.Click += SaveDocumentAs_Click;
            #endregion
        }

        private void SaveDocumentAs_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if(AppData.CurrentDocument != null)
            {
                AppData.CurrentDocument.SaveAsPDF();
            }
        }

        private void OpenHomePage_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var t = new AuraTabItem()
            {
                Content = new HomePage(),
                Header = "P�gina de Inicio"
            };
            AppData.MainWorkSpace.AddTab(t,true);
            t.Focus();
        }

        private void NewDocument_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            AppData.NewDocumentOnWorkSpace(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        
    }
}