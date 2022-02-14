using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopLibrary;

namespace NewDiscount
{
    public static class DiscountExtension
    {
        public static double GetTotalWithOtherDiscount(this Order NewOrder)
        {
            int fp = NewOrder.Customer.Total;            
            if (fp > 50000)
                return 15;
            else return 0;
        }
    }
}
