using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using SimpleCalculatorWeb.UITests.PageObjects;

namespace SimpleCalculatorWeb.UITests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class UITetsWithPageObjects
    {
        public UITetsWithPageObjects()
        {
        }

        [TestMethod]
        public void UI_Web_AddWithPageObject()
        {
            // Arrange
            var firstNumber = 2d;
            var secondNumber = 5d;
            var expectedResult = 7d;

            // Act 
            var app = SimpleCalculatorBrowser.Launch();
            app.CalculatorPanel
                .EnterFirstNumber(firstNumber)
                .EnterSecondNumber(secondNumber)
                .PressAdd();

            var result = app.CalculatorPanel.GetResultFieldValue();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void UI_WebChrome_AddWithPageObject()
        {
            // Arrange
            var firstNumber = 2d;
            var secondNumber = 5d;
            var expectedResult = 7d;

            // Act 
            var app = SimpleCalculatorBrowser.Launch(browser:"Chrome");
            app.CalculatorPanel
                .EnterFirstNumber(firstNumber)
                .EnterSecondNumber(secondNumber)
                .PressAdd();

            var result = app.CalculatorPanel.GetResultFieldValue();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

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
        private TestContext testContextInstance;
    }
}
