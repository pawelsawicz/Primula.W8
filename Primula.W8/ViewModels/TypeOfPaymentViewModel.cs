using Caliburn.Micro;
using Primula.W8.Common;
using Primula.W8.Enums;
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
                throw new NotImplementedException();
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
                Title = PaymentMethodsEnum.Cash,
                Popularity = 1,
                Image = "/Assets/mock_images/money.png"
            });
            methods.Add(new PaymentMethod()
            {
                Title = PaymentMethodsEnum.CreditCard,
                Popularity = 3,
                Image = "/Assets/mock_images/creditcard.png"
            });
            methods.Add(new PaymentMethod()
            {
                Title = PaymentMethodsEnum.Terminal,
                Popularity = 2,
                Image = "/Assets/mock_images/terminal.png"
            });
            methods.OrderBy(method => method.Popularity);
            AvailablePayments.AddRange(methods);
        }       

    }        
}
