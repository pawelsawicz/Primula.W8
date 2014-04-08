using Caliburn.Micro;
using Primula.W8.Common;
using Primula.W8.Enums;
using Primula.W8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Primula.W8.ViewModels
{
    public class TypeOfPaymentViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public TypeOfPaymentViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _title = "Type of Payment - Step 2/4";
            AvailablePayments = new BindableCollection<PaymentMethod>();
        }

        public void PaymentSelected(ItemClickEventArgs eventArgs)
        {
            var paymentSelected = (PaymentMethod)eventArgs.ClickedItem;

            if (paymentSelected != null)
            {
                switch (paymentSelected.PaymentMethods)
                {
                    case PaymentMethodsEnum.Cash:
                        _navigationService.UriFor<CashPaymentViewModel>().Navigate();
                        break;
                    case PaymentMethodsEnum.Terminal:
                        _navigationService.UriFor<CashPaymentViewModel>().Navigate();
                        break;
                    case PaymentMethodsEnum.CreditCard:
                        _navigationService.UriFor<CashPaymentViewModel>().Navigate();
                        break;
                    default:
                        _navigationService.UriFor<CashPaymentViewModel>().Navigate();
                        break;
                }
            }
        }

        public BindableCollection<PaymentMethod> AvailablePayments
        {
            get;
            private set;
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
        }

        protected override void OnInitialize()
        {
            var methods = new List<PaymentMethod>();
            methods.Add(new PaymentMethod()
            {
                Title = "Cash",
                Popularity = 1,
                Image = "/Assets/mock_images/money.png",
                PaymentMethods = PaymentMethodsEnum.Cash
            });
            methods.Add(new PaymentMethod()
            {
                Title = "Credit Card",
                Popularity = 3,
                Image = "/Assets/mock_images/creditcard.png",
                PaymentMethods = PaymentMethodsEnum.CreditCard
            });
            methods.Add(new PaymentMethod()
            {
                Title = "Terminal",
                Popularity = 2,
                Image = "/Assets/mock_images/terminal.png",
                PaymentMethods = PaymentMethodsEnum.Terminal
            });
            methods.OrderBy(method => method.Popularity);
            AvailablePayments.AddRange(methods);
        }       

    }        
}
