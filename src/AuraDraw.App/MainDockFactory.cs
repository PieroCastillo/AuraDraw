using Dock.Model;
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

          var root = CreateRootDock(); 
          
          return root; 
        }
    }
}