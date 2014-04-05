using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Primula.W8.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public DashboardViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _title = "Dashboard Page";
            _navigationService = navigationService;
        }

        public void TryPlaceNewOrder()
        {
            throw new NotImplementedException();
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
