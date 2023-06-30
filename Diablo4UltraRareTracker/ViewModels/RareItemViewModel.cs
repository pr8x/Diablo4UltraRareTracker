using System;
using System.Collections.Generic;
using Avalonia.Media;

namespace Diablo4UltraRareTracker.ViewModels;

internal record RareItemViewModel(string Name, string ToolTipImage, List<RareItemDropViewModel> Drops)
{
    public double EstimatedDropChance => 0;
}