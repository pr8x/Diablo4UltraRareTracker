using System;
using System.Net.Http;
using System.Threading.Tasks;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace Diablo4UltraRareTracker.ViewModels;

internal record RareItemDropViewModel(string? PlayerName, string? PlayerUrl, string? Region, DateTime? Date, string ProofImage)
{
    public Task<IImage> ResolvedProofImage => DownloadImage($"https://localhost:5001/{ProofImage}");

    private static async Task<IImage> DownloadImage(string url)
    {
        using var client = new HttpClient();

        var stream = await client.GetStreamAsync(url);

        return new Bitmap(stream);
    }
}