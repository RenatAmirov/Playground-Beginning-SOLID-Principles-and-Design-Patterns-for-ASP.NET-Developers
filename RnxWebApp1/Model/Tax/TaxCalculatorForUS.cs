﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnxWebApp1.Model.Tax
{
    public class TaxCalculatorForUS: CountryTaxCalculator
    {
        public override decimal CalculateTaxAmount()
        {
            // TODO Logic
            return 0;
        }
    }
}