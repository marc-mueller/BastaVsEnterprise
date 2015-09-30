using SimpleCalculatorWpf.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Input;

namespace SimpleCalculatorWpf.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for CalculationViewModelTest and is intended
    ///to contain all CalculationViewModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CalculationViewModelTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AddCommand
        ///</summary>
        [TestMethod()]
        public void AddCommandTest()
        {
            // Arrange
            CalculationViewModel target = new CalculationViewModel();
            int firstNumber = 2;
            int secondNumber = 2;
            int expected = 4;
            int actual;

            target.FirstNumber = firstNumber;
            target.SecondNumber = secondNumber;

            // Act
            target.AddCommand.Execute(null);
            actual = target.Result;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DivideCommand
        ///</summary>
        [TestMethod()]
        public void DivideCommandTest()
        {
            // Arrange
            CalculationViewModel target = new CalculationViewModel();
            int firstNumber = 4;
            int secondNumber = 2;
            int expected = 2;
            int actual;

            target.FirstNumber = firstNumber;
            target.SecondNumber = secondNumber;

            // Act
            target.DivideCommand.Execute(null);
            actual = target.Result;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for MultiplyCommand
        ///</summary>
        [TestMethod()]
        public void MultiplyCommandTest()
        {
            // Arrange
            CalculationViewModel target = new CalculationViewModel();
            int firstNumber = 2;
            int secondNumber = 2;
            int expected = 4;
            int actual;

            target.FirstNumber = firstNumber;
            target.SecondNumber = secondNumber;

            // Act
            target.MultiplyCommand.Execute(null);
            actual = target.Result;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SubtractCommand
        ///</summary>
        [TestMethod()]
        public void SubtractCommandTest()
        {
            // Arrange
            CalculationViewModel target = new CalculationViewModel();
            int firstNumber = 2;
            int secondNumber = 2;
            int expected = 0;
            int actual;

            target.FirstNumber = firstNumber;
            target.SecondNumber = secondNumber;

            // Act
            target.SubtractCommand.Execute(null);
            actual = target.Result;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
