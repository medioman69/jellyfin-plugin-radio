using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Jellyfin.Plugin.Radio
{
    public class RadioLibrary : ILibraryPostScanTask
    {
        public RadioLibrary()
        {
        }

        // Implementazione di ILibraryPostScanTask
        public Task Run(IProgress<double> progress, CancellationToken cancellationToken)
        {
            // Logica per aggiornare o elaborare i file dopo lo scan
            return Task.CompletedTask;
        }
    }
}