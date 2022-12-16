using System;
using System.Reactive.Linq;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaWeakHashList.ViewModels;

public class TimerViewModel : ViewModelBase
{
    [ObservableAsProperty] 
    private string? Time { get; }
    
    public TimerViewModel()
    {
        Observable.Interval(TimeSpan.FromSeconds(1)).Select(x => TimeSpan.FromSeconds(x).ToString("c")).ToPropertyEx(this, x => x.Time);
    }
}