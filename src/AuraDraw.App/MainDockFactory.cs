using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using Avalonia.Data;
using Dock.Model;
using Dock.Model.Controls;
using Dock.Avalonia.Controls;
using AuraDraw.App.Models;
using AuraDraw.App.ViewModels;
using AuraDraw.App.Views;

namespace AuraDraw.App
{
    public class MainDockFactory : Factory
    {
        private object _context;

        public MainDockFactory(object context)
        {
            _context = context;
        }

        public override IDock CreateLayout(){
          
          //Documents Dock
          var editor = new Editor_VM{
              Id = "editor",
              Title = "Editor"
          };
          var viewbox = new ViewBox_VM{
              Id = "viewbox",
              Title = "SVG View"
          };
          //Tools Dock
          var colorspalette = new ColorPalette_VM{
              Id = "colorspalette",
              Title = "Paleta"
          };
          var objectsview = new ObjectsView_VM{
              Id = "objectsview",
              Title = "Árbol de objetos"
          };
          var objectsbox = new ObjectsBox_VM{
              Id = "objectsbox",
              Title = "Cuadro Agregar Objetos"
          };
          //MainView
          var mainLayout = new ProportionalDock{
              Id = "MainLayout",
              Title = "MainLayout",
              Proportion = double.NaN,
              Orientation = Orientation.Horizontal,
              ActiveDockable = null,
              VisibleDockables = CreateList<IDockable>(
                  new ProportionalDock
                    {
                        Id = "LeftPane",
                        Title = "LeftPane",
                        Proportion = double.NaN,
                        Orientation = Orientation.Vertical,
                        ActiveDockable = null,
                        VisibleDockables = CreateList<IDockable>
                        (
                            new ToolDock
                            {
                                Id = "LeftPaneTop",
                                Title = "LeftPaneTop",
                                Proportion = double.NaN,
                                ActiveDockable = null,
                                VisibleDockables = CreateList<IDockable>
                                (
                                    colorspalette
                                )
                            }
                                                  
                        )
                    },
                  new SplitterDock()
                    {
                        Id = "LeftSplitter",
                        Title = "LeftSplitter"
                    },
                  new DocumentDock
                    {
                        Id = "DocumentsPane",
                        Title = "DocumentsPane",
                        Proportion = double.NaN,
                        ActiveDockable = editor,
                        VisibleDockables = CreateList<IDockable>
                        (
                            editor,
                            viewbox
                        )
                    },
                  new SplitterDock()
                    {
                        Id = "RightSplitter",
                        Title = "RightSplitter"
                    },
                  new ProportionalDock
                    {
                        Id = "RightPane",
                        Title = "RightPane",
                        Proportion = double.NaN,
                        Orientation = Orientation.Vertical,
                        ActiveDockable = null,
                        VisibleDockables = CreateList<IDockable>
                        (
                            new ToolDock
                            {
                                Id = "RightPaneTop",
                                Title = "RightPaneTop",
                                Proportion = double.NaN,
                                ActiveDockable = objectsview,
                                VisibleDockables = CreateList<IDockable>
                                (
                                    objectsbox,
                                    objectsview
                                )
                            }
                            
                        )
                    }
              )
          };
          var mainView = new MainView_VM{
              Id = "Main",
              Title = "Main",
              ActiveDockable = mainLayout,
              VisibleDockables = CreateList<IDockable>(mainLayout)
          };
          var root = CreateRootDock(); 
          root.Id = "Root";
            root.Title = "Root";
            root.ActiveDockable = mainView;
            root.DefaultDockable = mainView;
            root.VisibleDockables = CreateList<IDockable>(mainView);
            root.Top = CreatePinDock();
            root.Top.Alignment = Alignment.Top;
            root.Bottom = CreatePinDock();
            root.Bottom.Alignment = Alignment.Bottom;
            root.Left = CreatePinDock();
            root.Left.Alignment = Alignment.Left;
            root.Right = CreatePinDock();
            root.Right.Alignment = Alignment.Right;
          
          return root; 
        }

        public override void InitLayout(IDockable layout){
           
            this.ContextLocator = new Dictionary<string, Func<object>>{
                [nameof(IRootDock)] = () => _context,
                [nameof(IPinDock)] = () => _context,
                [nameof(IProportionalDock)] = () => _context,
                [nameof(IDocumentDock)] = () => _context,
                [nameof(IToolDock)] = () => _context,
                [nameof(ISplitterDock)] = () => _context,
                [nameof(IDockWindow)] = () => _context,
                [nameof(IDocument)] = () => _context,
                [nameof(ITool)] = () => _context,
                ["editor"] = () => new Editor_M(),
                ["viewbox"] = () => new ViewBox_M(),
                ["colorspalette"] = () => new ColorPalette_M(),
                ["objectsview"] = () => new ObjectsView_M(),
                ["objectsbox"] = () => new ObjectsBox_M(),
                ["MainView"] = () => _context,
                ["Main"] = () => _context,
            } ;

            this.HostWindowLocator = new Dictionary<string, Func<IHostWindow>>
            {
                [nameof(IDockWindow)] = () =>
                {
                    var hostWindow = new HostWindow()
                    {
                        [!HostWindow.TitleProperty] = new Binding("ActiveDockable.Title")
                    };
                    return hostWindow;
                }
            };

            this.DockableLocator = new Dictionary<string, Func<IDockable>>
            {
            };

            base.InitLayout(layout);
        }
    }
}