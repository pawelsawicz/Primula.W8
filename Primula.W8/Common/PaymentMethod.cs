using Primula.W8.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primula.W8.Common
{
    public class PaymentMethod
    {
        public string Title { get; set; }
        public int Popularity { get; set; }        
        public string Image { get; set; }
        public PaymentMethodsEnum PaymentMethods { get; set; }
    }
}
