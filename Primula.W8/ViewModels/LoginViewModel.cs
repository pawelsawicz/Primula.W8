using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Primula.W8.ViewModels;
using Primula.W8.Views;

namespace Primula.W8.ViewModels
{
    public class LoginViewModel : ViewModelBase 
    {
        private readonly INavigationService _navigationService;

        public LoginViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _title = "Login Page";
            _navigationService = navigationService;
        }

        public void TryLogin()
        {
            _navigationService.Navigate(typeof(DashboardView));
        }        

        protected override void OnInitialize()
        {
            base.OnInitialize();
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
        }

    }
}
