using ReactiveUI;
using System;

namespace BasicMvvmSample.ViewModels;

public class ReactiveViewModel : ReactiveObject
{
   private string? _name;

   public ReactiveViewModel()
   {
      this.WhenAnyValue(o => o.Name)
         .Subscribe(_ => this.RaisePropertyChanged(nameof(Greeting)));
   } 

   public string? Name
   {
      get => _name;
      set => this.RaiseAndSetIfChanged(ref _name, value);
   }

   public string Greeting
   {
      get
      {
         if (string.IsNullOrEmpty(Name)) {
            return "Hello World from Avalonia.Samples";
         }

         return $"Hello {Name}";
      }
   }
}