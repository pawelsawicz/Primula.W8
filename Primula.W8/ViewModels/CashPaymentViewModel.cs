using Caliburn.Micro;
using Primula.W8.NotifyViewModels;
using Primula.W8.Views;
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
            ListOfProducts = new List<ProductPaymentViewModel>();
        }

        public List<ProductPaymentViewModel> ListOfProducts
        {
            get;
            set;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
        }

        private decimal _totalDue;
        public decimal TotalDue
        {
            get
            {
                return _totalDue;
            }
            set
            {
                _totalDue = value;
                NotifyOfPropertyChange(() => TotalDue);
            }
        }

        private string _customerCash;
        public string CustomerCash
        {
            get
            {
                return _customerCash;
            }
            set
            {
                _customerCash = value;                
                NotifyOfPropertyChange(() => CustomerCash);   
                CalculateChange();
            }
        }

        private decimal _change;
        public decimal Change
        {
            get
            {
                return _change;
            }
            set
            {
                _change = value;
                NotifyOfPropertyChange(() => Change);                
            }
        }

        private void CalculateChange()
        {
            if (!string.IsNullOrEmpty(CustomerCash))
            {
                var parsedCash = decimal.Parse(CustomerCash);
                if (parsedCash > TotalDue)
                {
                    Change = parsedCash - TotalDue;
                }
            }
        }
  
        public void FinalizePayment()
        {
            _navigationService.Navigate(typeof(FinalizePaymentView));
        }       

        protected override void OnInitialize()
        {
            List<ProductPaymentViewModel> mockedData = new List<ProductPaymentViewModel>();
            mockedData.Add(new ProductPaymentViewModel()
            {
                ProductId = 1,
                BruttoPrice = 49.99M,
                TypeOfTax = new TypeOfTax()
                {
                    Name = "A",
                    Amount = 0.23M
                },
            });

            mockedData.Add(new ProductPaymentViewModel()
            {
                ProductId = 1,
                BruttoPrice = 18.99M,
                TypeOfTax = new TypeOfTax()
                {
                    Name = "B",
                    Amount = 0.18M
                },
            });

            mockedData.Add(new ProductPaymentViewModel()
            {
                ProductId = 1,
                BruttoPrice = 10.99M,
                TypeOfTax = new TypeOfTax()
                {
                    Name = "C",
                    Amount = 0.5M
                },
            });

            ListOfProducts.AddRange(mockedData);
            TotalDue = GetTotalDue(ListOfProducts);

        }

        private decimal GetTotalDue(ICollection<ProductPaymentViewModel> productsToCompute)
        {
            decimal totalDue = 0;
            foreach (var item in productsToCompute)
            {
                totalDue += item.BruttoPrice;
            }
            return totalDue;
        }
    }
}
