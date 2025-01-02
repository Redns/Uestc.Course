using Microsoft.FluentUI.AspNetCore.Components;

namespace Uestc.Course.Pages
{
    public partial class Home
    {
        int ProgressPercent = 0;
        FluentInputFileEventArgs[] Files = Array.Empty<FluentInputFileEventArgs>();

        private async Task OnCompletedAsync(IEnumerable<FluentInputFileEventArgs> files)
        {
            Files = files.ToArray();

            // For the demo, delete these files.
            foreach (var file in Files)
            {
                file.LocalFile?.Delete();
            }

            // Wait 3 seconds before to reset the progress bar.
            await Task.Delay(3000);
            ProgressPercent = 0;
        }
    }
}
