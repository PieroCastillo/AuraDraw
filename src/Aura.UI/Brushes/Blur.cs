using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Collections;
using Avalonia.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aura.UI.Brushes
{
    public class Blur
    {
        public Bitmap NewAcrylicSource(double Radius,AcrylicBrushTheme theme = AcrylicBrushTheme.Light){
            return null;
        }
        public IBitmap BlurImage(CloneableBitmap bitmap,double Radius){
            
            var b_height = bitmap.Size.Height;
            var b_width = bitmap.Size.Width;
            var bmp = bitmap.Clone();
 
            var pixels = new AvaloniaList<Avalonia.PixelPoint>();
            /* for ( int i = 0 ; i < b_width -1 ; )
            {
               for ( int g = 0 ; g < b_height -1 ;  )
               {
                
               }
            } */
    
            return null;
        }
    }


}
namespace Avalonia.Media.Imaging{

    public class CloneableBitmap : Bitmap,IBitmap,ICloneable{

       public CloneableBitmap(IBitmapImpl impl) : base(impl){}
       public CloneableBitmap(IRef<IBitmapImpl> impl) : base(impl){}
       public CloneableBitmap(PixelFormat format, IntPtr data, PixelSize size, Vector dpi, int stride) : base(format,data,size,dpi,stride){}
       public CloneableBitmap(Stream stream) : base(stream){}
       public CloneableBitmap(string path) : base(path){}


       public object Clone(){
           return this.MemberwiseClone();
       }
    }
}
