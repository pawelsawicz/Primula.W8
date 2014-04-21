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

        public void AddProductToOrder()
        {            
            _navigationService.Navigate(typeof(DashboardView));
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
