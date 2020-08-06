using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.VisualTree;
using AvaloniaPrintToPdf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aura.CommonCore.IO
{
    public static class PDF
    {
        public static void VisualToPDF(this IVisual Visual)
        {
           Save("Save as PDF", "currentDoc.pdf", filename =>
            {
                var output = Visual;
                Print.ToFile(filename, output);
            });
        }

        public static Task<string> Save(string title, string defaultFilename)
        {
            var saveDialog = new SaveFileDialog()
            {
                Title = title,
                Filters = PDFFilters,
                InitialFileName = defaultFilename
            };
            var mainWindow = (Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow;
            return saveDialog.ShowAsync(mainWindow);
        }

        public static async void Save(string title, string defaultFilename, Action<string> saveAction)
        {
            var filename = await Save(title, defaultFilename);
            if (filename != null)
                saveAction(filename);
        }

        private static List<FileDialogFilter> PDFFilters => new List<FileDialogFilter>
        {
            new FileDialogFilter { Name = "PDF files (.pdf)", Extensions = new List<string> {"pdf"} },
            new FileDialogFilter { Name = "All files", Extensions = new List<string> {"*"} }
         };
    }
}
