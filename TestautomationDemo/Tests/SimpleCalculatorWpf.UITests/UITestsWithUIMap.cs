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
using SimpleCalculatorWpf.UITests.PageObjects;

namespace SimpleCalculatorWpf.UITests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class UITestsWithUIMap
    {
        public UITestsWithUIMap()
        {

        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.TestCase", "http://vsalm:8080/tfs/simplecalculator;SimpleCalculator", "1", DataAccessMethod.Sequential), TestMethod]
        public void CodedUITestMethod1()
        {


            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            this.UIMap.EnterfirstnumberintotheleftfieldParams.UIInputNumber1EditText = TestContext.DataRow["firstnumber"].ToString();
            this.UIMap.Enterfirstnumberintotheleftfield();
            this.UIMap.EntersecondnumberintotherightfieldParams.UIInputNumber2EditText = TestContext.DataRow["secondnumber"].ToString();
            this.UIMap.Entersecondnumberintotherightfield();
            this.UIMap.PressAdd();
            this.UIMap.VerifyResultExpectedValues.UIResultingNumberEditText = TestContext.DataRow["result"].ToString();
            this.UIMap.VerifyResult();
            this.UIMap.CloseApplication();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        //Use TestInitialize to run code before running each test 

        ApplicationUnderTest app;
        [TestInitialize()]
        public void MyTestInitialize()
        {
            app = ApplicationUnderTest.Launch(@"C:\ws\brian\SimpleCalculator\Main\SimpleCalculatorUI\bin\Debug\SimpleCalculatorUI.exe");
        }

        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {        
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        }

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

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
