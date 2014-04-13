using Caliburn.Micro;
using Primula.W8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primula.W8.ViewModels
{
    public class FinalizePaymentViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public FinalizePaymentViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _title = "Finalize Payment - Step 4/4";
            OrderedTypesOfProducts = new BindableCollection<OrderedTypeOfProduct>();
        }

        public void ConfirmAndReturnToDashboard()
        {
            _navigationService.Navigate(typeof(DashboardView));
        }

        protected override void OnInitialize()
        {
            var typesOfProducts = new List<OrderedTypeOfProduct>();
            typesOfProducts.Add(new OrderedTypeOfProduct()
            {
                Name = "Groceries",
                TotalPrice = 68
            });
            typesOfProducts.Add(new OrderedTypeOfProduct()
            {
                Name = "Toiletries",
                TotalPrice = 32
            });
            typesOfProducts.Add(new OrderedTypeOfProduct()
            {
                Name = "Electrical goods",
                TotalPrice = 140
            });

            OrderedTypesOfProducts.AddRange(typesOfProducts);
        }

        public BindableCollection<OrderedTypeOfProduct> OrderedTypesOfProducts
        {
            get;
            private set;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
        }
    }

    public class OrderedTypeOfProduct
    {
        public string Name { get; set; }
        public int TotalPrice { get; set; } 
    }
}
