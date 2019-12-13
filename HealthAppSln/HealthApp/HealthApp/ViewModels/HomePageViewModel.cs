using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Navigation.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {

        private DelegateCommand _menu;
        public DelegateCommand Menu =>
            _menu ?? (_menu = new DelegateCommand(ExecuteMenu));

        async void ExecuteMenu()
        {
            await NavigationService.NavigateAsync("MasterPage/NavigationPage/AppointmentPage", useModalNavigation: true) ;
        }


    

        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Appointments";

        }
    }
}
