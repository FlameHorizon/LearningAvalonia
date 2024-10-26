using System;
using ReactiveUI;

namespace BasicMvvmSample.ViewModels;

public class PersonalViewModel : ReactiveViewModel
{
   private string? _name;
   private string? _surname;
   private DateTime? _dateOfBirth;

   public PersonalViewModel()
   {
      this.WhenAnyValue(o => o.Name).Subscribe(_ => this.RaisePropertyChanged(nameof(Greeting)));
   }

   public string? Name
   {
      get => _name;
      set => this.RaiseAndSetIfChanged(ref _name, value);
   }

   public string? Surname
   {
      get => _surname;
      set => this.RaiseAndSetIfChanged(ref _surname, value);
   }
   
   public DateTime? DateOfBirth 
   {
      get => _dateOfBirth;
      set => this.RaiseAndSetIfChanged(ref _dateOfBirth, value);
   }

   public string Greeting
   {
      get
      {
         if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || _dateOfBirth == DateTime.MinValue) {
            return "Hello World from AValonia.Samples";
         }

         TimeSpan? bornDaysAgo = DateTime.Today - DateOfBirth;
         return $"Hello {Name} {Surname}. You awere born {bornDaysAgo.Value.Days} days ago.";
      }
   }
   
}