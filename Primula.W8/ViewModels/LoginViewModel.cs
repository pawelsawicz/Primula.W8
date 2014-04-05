using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Primula.W8.ViewModels;

namespace Primula.W8.ViewModels
{
    public class LoginViewModel : ViewModelBase 
    {
        public LoginViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _title = "Login Page";
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
