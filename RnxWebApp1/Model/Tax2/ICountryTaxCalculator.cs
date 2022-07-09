using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnxWebApp1.Model.Tax2
{
    public interface ICountryTaxCalculator
    {
        decimal CalculateTaxAmount();
    }
}
