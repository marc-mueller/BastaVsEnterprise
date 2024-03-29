using Taxation.Models;
// <copyright file="TaxCalculatorTest.cs">Copyright ©  2014</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taxation;

namespace Taxation.Tests
{
    [TestClass]
    [PexClass(typeof(TaxCalculator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TaxCalculatorTest
    {

        [PexMethod]
        [PexAllowedException(typeof(InvalidLocationException))]
        public uint CalculateExemptionForRent(Employee employee)
        {
            uint result = TaxCalculator.CalculateExemptionForRent(employee);
            return result;
            // TODO: add assertions to method TaxCalculatorTest.CalculateExemptionForRent(Employee)
        }
    }
}
