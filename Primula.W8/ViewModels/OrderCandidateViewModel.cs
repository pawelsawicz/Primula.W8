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
    public class OrderCandidateViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public OrderCandidateViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _title = "New Order - Step 1 / 4";
            ProductsOrder = new BindableCollection<ProductOrderViewModel>();
        }

        public BindableCollection<ProductOrderViewModel> ProductsOrder
        {
            get;
            private set;
        }

        public void ProceedToPayment()
        {
            _navigationService.Navigate(typeof(TypeOfPaymentView));
        }

        public void AddNewProductManually()
        {
            _navigationService.Navigate(typeof(NewProductToOrderView));
        }

        public void AddNewProductCamera()
        {
            _navigationService.Navigate(typeof(NewProductToOrderByCameraView));
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
        }

        private int _totalCount;
        public int TotalCount
        {
            get
            {
                return _totalCount;
            }
            set
            {
                _totalCount = value;
                NotifyOfPropertyChange(() => TotalCount);
            }
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

        public int ProductIdFromSearchEngine { get; set; }

        protected override void OnInitialize()
        {
            if (ProductIdFromSearchEngine != 0)
            {
                var product = GetProductById(ProductIdFromSearchEngine);
                ProductsOrder.Add(product);
                TotalCount = ProductsOrder.Count;
                TotalDue = GetTotalDue(ProductsOrder);
            }
        }

        private decimal GetTotalDue(ICollection<ProductOrderViewModel> productsToCompute)
        {
            decimal totalDue = 0;
            foreach (var item in productsToCompute)
            {
                totalDue += item.BruttoPrice;
            }
            return totalDue;
        }

        private ProductOrderViewModel GetProductById(int productId)
        {
            return new ProductOrderViewModel()
                {
                    Name = "New Boots",
                    Amount = 1.0M,
                    Unit = Enums.UnitsEnum.Item,
                    BruttoPrice = 49.99M
                };
        }
    }
}
