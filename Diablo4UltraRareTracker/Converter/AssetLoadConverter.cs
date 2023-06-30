using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace Diablo4UltraRareTracker.Converter;

internal class AssetLoadConverter : IValueConverter
{
    public static AssetLoadConverter Instance = new();

    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var asset = AssetLoader.Open(new Uri($"avares://Diablo4UltraRareTracker/Assets/{(string)value!}"));

        return new Bitmap(asset);
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}