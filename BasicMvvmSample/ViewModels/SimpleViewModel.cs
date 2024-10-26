using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BasicMvvmSample.ViewModels;

public class SimpleViewModel : INotifyPropertyChanged
{
    private string _name;
    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public string Name
    {
        get => _name;
        set
        {
            if (value != _name) {
                _name = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(Greeting));
            }
        }
    }

    public string Greeting => string.IsNullOrEmpty(Name) 
        ? "Hello World from Avalonia.Samples" 
        : $"Hello {_name}";
}