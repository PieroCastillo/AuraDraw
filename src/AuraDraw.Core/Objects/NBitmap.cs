using System.Runtime.CompilerServices;
using System.IO;
using System;
using Avalonia;
using Avalonia.Platform;
using Avalonia.Utilities;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace AuraDraw.Core.Objects{

    public class NBitmap : IBitmap , ICloneable{

       /// <inheritdoc/>
        public Vector Dpi => PlatformImpl.Item.Dpi;

        /// <inheritdoc/>
        public Size Size => PlatformImpl.Item.PixelSize.ToSizeWithDpi(Dpi);

        /// <inheritdoc/>
        public PixelSize PixelSize => PlatformImpl.Item.PixelSize;

        /// <summary>
        /// Gets the platform-specific bitmap implementation.
        /// </summary>
        public IRef<IBitmapImpl> PlatformImpl { get; }

        /// <summary>
        /// Saves the bitmap to a file.
        /// </summary>
        /// <param name="fileName">The filename.</param>
        public void Save(string fileName)
        {
            PlatformImpl.Item.Save(fileName);
        }

        public void Save(Stream stream)
        {
            PlatformImpl.Item.Save(stream);
        }

        public void Dispose()
        {
            PlatformImpl.Dispose();
        }

        public object Clone(){
            return this.MemberwiseClone();
        }
    }

    public class Pixel : ICloneable 
    {
        public byte r { get; set;}
        public byte g { get; set;}
        public byte b { get; set;}
        public byte a { get; set;}

        public object Clone()
        {
             return this.MemberwiseClone(); 
        }
        public void ChangeColor(byte a,byte r,byte g,byte b){
           this.a = a;
           this.r = r;
           this.g = g;
           this.b = b;
        }
    }
    
}