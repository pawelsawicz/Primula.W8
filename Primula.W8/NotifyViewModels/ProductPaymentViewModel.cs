using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primula.W8.NotifyViewModels
{
    public class ProductPaymentViewModel : PropertyChangedBase
    {
        public int ProductId { get; set; }
        public decimal BruttoPrice { get; set; }
        public TypeOfTax TypeOfTax { get; set; }
    }

    public class TypeOfTax
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
