using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaWeakHashList.Views;

public partial class Timer : UserControl
{
    public Timer()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private string? _text;

    public static readonly DirectProperty<Timer, string?> TextProperty = AvaloniaProperty.RegisterDirect<Timer, string?>(
        "Text", o => o.Text, (o, v) => o.Text = v);

    public string? Text
    {
        get => _text;
        set => SetAndRaise(TextProperty, ref _text, value);
    }
}