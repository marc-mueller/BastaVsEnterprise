namespace TaxCalculators
{
    using System;
    using Models;

    public class TaxCalculator
    {
        public uint CalculateExemptionForRent(
            Employee        employee,
            ITaxCalculator  ic)
        {
            var taxExemption = ic.calculate(
                                    employee.Property.IsRented,
                                    employee.Property.Location,
                                    employee.AnnualBasicSalary,
                                    employee.Property.MonthlyRent,
                                    employee.AnnualHouseRentAllowance);

            return taxExemption;
        }
    }
}
