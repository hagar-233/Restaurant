using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp131
{
    internal class Billing
    {
        public static double CalculateBilling()
        {
            double tex = 0.182;
            double totalp = Order.totalprice();
            double Billing =totalp + (totalp*tex);
            return Billing;

        }
    }
}
