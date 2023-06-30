using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Media;
using Diablo4UltraRareTracker.ViewModels;

namespace Diablo4UltraRareTracker.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void DropProofImageClicked(object? sender, PointerPressedEventArgs e)
    {
        var img = (Image)sender!;

        FlyoutBase.SetAttachedFlyout(this, new Flyout
        {
            Content = new Border
            {
                MaxWidth = 100000,
                Width = 1000,
                Height = 1000,
                Child =
                    new Image
                    {
                        Source = img.Source,
                        Stretch = Stretch.UniformToFill
                    }
            }
        });

        FlyoutBase.ShowAttachedFlyout(this);
    }

    private void PlayerName_PointerPressed(object? sender, PointerPressedEventArgs e)
    {
        var tb = (TextBlock)sender!;
        var drop = (RareItemDropViewModel)tb.DataContext!;

        if (drop.PlayerUrl is { } url)
        {
            Process.Start(url);
        }
    }
}