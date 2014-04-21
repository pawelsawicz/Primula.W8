using Caliburn.Micro;
using Primula.W8.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primula.W8.NotifyViewModels
{
    public class ProductOrderViewModel : PropertyChangedBase
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public UnitsEnum Unit { get; set; }
        public decimal BruttoPrice { get; set; }
    }
}
