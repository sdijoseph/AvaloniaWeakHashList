using System.Collections.Generic;

namespace AvaloniaWeakHashList.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public List<TimerViewModel> Timers { get; }

    public MainWindowViewModel()
    {
        Timers = new List<TimerViewModel>();

        for (int i = 0; i < 30; i++)
        {
            Timers.Add(new TimerViewModel());
        }
    }
}