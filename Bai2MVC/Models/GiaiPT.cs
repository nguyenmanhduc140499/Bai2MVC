using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai2MVC.Models
{
    public class GiaiPT
    {
        public double GiaiPTBN(double a, double b)
        {
            double x;
            x = -b / a;
            return x;
        }
    }
}