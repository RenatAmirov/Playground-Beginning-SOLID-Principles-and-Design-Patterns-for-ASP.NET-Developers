using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnxWebApp1.Model.Tax
{
    public abstract class CountryTaxCalculator
    {
        public abstract decimal CalculateTaxAmount();
    }
}