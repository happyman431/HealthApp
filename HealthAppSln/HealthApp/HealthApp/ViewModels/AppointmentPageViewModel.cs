using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.ViewModels
{
    public class AppointmentPageViewModel : ViewModelBase
    {
       
            private DelegateCommand _cancel;
        public DelegateCommand CancelCommand =>
            _cancel ?? (_cancel = new DelegateCommand(ExecuteCancel));

        private DelegateCommand _saveCommand;
        public DelegateCommand SaveCommand =>
            _saveCommand ?? (_saveCommand = new DelegateCommand(ExecuteSaveCommand));

       async void ExecuteSaveCommand()
        {
            await NavigationService.NavigateAsync("HomePage");
        }
        async void ExecuteCancel()
        {
            await NavigationService.NavigateAsync("MainPage");
        }

        public AppointmentPageViewModel(INavigationService navigationService) :base(navigationService)
        {

        }
    }
}
