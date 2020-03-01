using Dock.Model;

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
          
          var root = CreateRootDock(); 
          
          return root; 
        }
    }
}