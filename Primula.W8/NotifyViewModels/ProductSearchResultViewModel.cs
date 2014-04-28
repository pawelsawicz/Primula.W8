using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Primula.W8.Enums;

namespace Primula.W8.NotifyViewModels
{
    public class ProductSearchResultViewModel : PropertyChangedBase
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public UnitsEnum Unit { get; set; }
        public decimal BruttoPrice { get; set; }
        public CurrencyEnum Currency { get; set; }        
    } 
}
