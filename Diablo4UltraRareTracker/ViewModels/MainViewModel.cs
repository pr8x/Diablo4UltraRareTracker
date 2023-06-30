using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ReactiveUI.Fody.Helpers;

namespace Diablo4UltraRareTracker.ViewModels;

internal class MainViewModel : ViewModelBase
{
    [Reactive] public List<RareItemViewModel>? RareItems { get; private set; }

    public async Task Initialize()
    {
        using var client = new HttpClient();
        var dbJson = await client.GetStringAsync("https://localhost:5001/db.json");

        RareItems = JsonSerializer.Deserialize<List<RareItemViewModel>>(dbJson)
                    ?? new List<RareItemViewModel>();
    }
}