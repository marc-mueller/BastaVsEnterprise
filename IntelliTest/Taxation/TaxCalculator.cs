namespace Taxation
{
    using System;
    using System.Diagnostics;

    using Taxation.Models;

    public class TaxCalculator
    {
        public static uint CalculateExemptionForRent(
            Employee employee)
        {
            var taxExemption = default(uint);


            // Demo
            if(employee == null)
            {
                throw new ArgumentNullException("employee");
            }

            if (employee.Property.IsRented == false)
            {
                return taxExemption;
            }

            // Calculate location based allowance
            var locationAllowance = default(uint);
            switch (employee.Property.Location)
            {
                case Location.Metro:
                    locationAllowance = Convert.ToUInt32(Math.Ceiling(0.5 * employee.AnnualBasicSalary));
                    break;
                case Location.NonMetro:
                    locationAllowance = Convert.ToUInt32(Math.Ceiling(0.4 * employee.AnnualBasicSalary));
                    break;
                default:
                    throw new InvalidLocationException();
            }

            // Calculate default house rent allowance
            var defaultHRA = 12 * employee.Property.MonthlyRent - Convert.ToUInt32(Math.Ceiling(0.1 * employee.AnnualBasicSalary));

            // Calculate the minimum
            taxExemption = defaultHRA;
            if (locationAllowance < defaultHRA)
            {
                taxExemption = locationAllowance;
            }

            if (employee.AnnualHouseRentAllowance < taxExemption)
            {
                taxExemption = employee.AnnualHouseRentAllowance;
            }

            return taxExemption;
        }

        public static int CalculateExemptionForRule80C(
            Employee employee)
        {
            // TODO
            throw new NotImplementedException();
        }
    }

    internal class Class1
    {
        public bool isEven(int i)
        {
            if (i % 2 == 0) return true;
            else return false;
        }
    }
}