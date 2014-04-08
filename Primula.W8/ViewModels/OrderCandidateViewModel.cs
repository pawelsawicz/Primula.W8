using Caliburn.Micro;
using Primula.W8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primula.W8.ViewModels
{
    public class OrderCandidateViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public OrderCandidateViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _title = "New Order - Step 1 / 4";
        }

        public void ProceedToPayment()
        {
            _navigationService.Navigate(typeof(TypeOfPaymentView));
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
