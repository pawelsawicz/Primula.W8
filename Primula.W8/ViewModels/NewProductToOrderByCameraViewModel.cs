using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primula.W8.ViewModels
{
    public class NewProductToOrderByCameraViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public NewProductToOrderByCameraViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _title = "Add new product to order by camera";
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
