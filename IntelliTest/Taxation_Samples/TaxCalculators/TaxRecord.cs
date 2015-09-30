using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculators
{
    using DAL;
    using Models;

    public class TaxRecord
    {
        private IDAL d;
        public TaxRecord(
            IDAL id)
        {
            d = id;
        }

        public bool EmployeeHRADeductionEligible(
            Employee employee)
        {
            uint val = d.HRA(employee);

            if (val > 0)
                return true;
            else
                return false;
        }
    }
}
