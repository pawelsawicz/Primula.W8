using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primula.W8.ViewModels
{
    public class CashPaymentViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public CashPaymentViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _title = "Cash Payment - Step 3/4";
        }

        private string _title;
        public string Title
        {
            get { return _title; }
        }

        public void FinalizePayment()
        {
            
        }
    }
}
