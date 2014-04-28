using Caliburn.Micro;
using Primula.W8.Enums;
using Primula.W8.NotifyViewModels;
using Primula.W8.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Primula.W8.ViewModels
{
    public class NewProductToOrderViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public NewProductToOrderViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _title = "Add new product to order view";
            ProductSearchResult = new BindableCollection<ProductSearchResultViewModel>();
        }

        public BindableCollection<ProductSearchResultViewModel> ProductSearchResult
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

        private string _searchQuery;
        public string SearchQuery
        {
            get
            {
                return _searchQuery;
            }
            set
            {
                _searchQuery = value;
                NotifyOfPropertyChange(() => SearchQuery);
            }
        }


        public void ProductSearch()
        {
            var mockCollection = new List<ProductSearchResultViewModel>();
            mockCollection.Add(new ProductSearchResultViewModel()
            {
                ProductId = 1,
                Name = "Air Max",
                Producer = "Nike",
                Unit = UnitsEnum.Item,
                BruttoPrice = 49.99M,
                Currency = CurrencyEnum.USD
            });
            mockCollection.Add(new ProductSearchResultViewModel()
            {
                ProductId = 2,
                Name = "New Balance",
                Producer = "Adidas",
                Unit = UnitsEnum.Item,
                BruttoPrice = 39.99M,
                Currency = CurrencyEnum.USD
            });

            ProductSearchResult.AddRange(mockCollection);
        }

        public bool CanProductSearch
        {
            get
            {
                if (!string.IsNullOrEmpty(SearchQuery))
                {
                    return true;
                }

                return false;
            }
        }

        private int _selectedProductId { get; set; }

        public void ProductSearchSelectionChanged(SelectionChangedEventArgs eventArgs)
        {
            var itemSelected = (ProductSearchResultViewModel)eventArgs.AddedItems.FirstOrDefault();

            if (itemSelected != null)
            {
                _selectedProductId = itemSelected.ProductId;
            }
        }

        public bool CanAddProductToOrder
        {
            get
            {
                if (_selectedProductId != 0)
                {
                    return true;
                }

                return false;
            }
        }

        public void AddProductToOrder()
        {
            _navigationService.UriFor<OrderCandidateViewModel>().WithParam<int>(viewModel => viewModel.ProductIdFromSearchEngine, _selectedProductId).Navigate();
        }

        public void ClearProductSearch()
        {
            ProductSearchResult.Clear();
        }

        protected override void OnInitialize()
        {
            
        }
    }
}
