namespace BasicMvvmSample.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static
    
    public SimpleViewModel SimpleViewModel { get; } = new SimpleViewModel();
    public ReactiveViewModel ReactiveViewModel { get; } = new ReactiveViewModel();
    public PersonalViewModel PersonalViewModel { get; } = new PersonalViewModel();
}