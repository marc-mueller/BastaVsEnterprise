using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using PageObjectsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorWpf.UITests.PageObjects
{
    public class CalculatorPanelPageObject : PageObjectBase
    {
        private WpfEdit firstNumberField;
        private WpfEdit secondNumberField;
        private WpfEdit resultField;
        private WpfButton addButton;
        private WpfButton subtractButton;
        private WpfButton multiplyButton;
        private WpfButton divideButton;

        public CalculatorPanelPageObject(UITestControl parentControl) : base(parentControl)
        {

        }

        public WpfEdit FirstNumberField
        {
            get
            {
                if (firstNumberField == null)
                {
                    firstNumberField = FindControlById<WpfEdit>("SimpleCalculatorTxtFirstNumber");
                }
                return firstNumberField;
            }
        }

        public WpfEdit SecondNumberField
        {
            get
            {
                if (secondNumberField == null)
                {
                    secondNumberField = FindControlById<WpfEdit>("SimpleCalculatorTxtSecondNumber");
                }
                return secondNumberField;
            }
        }

        public WpfEdit ResultField
        {
            get
            {
                if (resultField == null)
                {
                    resultField = FindControlById<WpfEdit>("SimpleCalculatorTxtResult");
                }
                return resultField;
            }
        }

        public WpfButton AddButton
        {
            get
            {
                if (addButton == null)
                {
                    addButton = FindControlById<WpfButton>("SimpleCalculatorBtnAdd");
                }
                return addButton;
            }
        }

        public WpfButton SubtractButton
        {
            get
            {
                if (subtractButton == null)
                {
                    subtractButton = FindControlById<WpfButton>("SimpleCalculatorBtnSubtract");
                }
                return subtractButton;
            }
        }

        public WpfButton MultiplyButton
        {
            get
            {
                if (multiplyButton == null)
                {
                    multiplyButton = FindControlById<WpfButton>("SimpleCalculatorBtnMultiply");
                }
                return multiplyButton;
            }
        }

        public WpfButton DivideButton
        {
            get
            {
                if (divideButton == null)
                {
                    divideButton = FindControlById<WpfButton>("SimpleCalculatorBtnDivide");
                }
                return divideButton;
            }
        }

        public CalculatorPanelPageObject EnterFirstNumber(double number)
        {
            this.FirstNumberField.Text = number.ToString();
            return this;
        }

        public CalculatorPanelPageObject EnterSecondNumber(double number)
        {
            this.SecondNumberField.Text = number.ToString();
            return this;
        }

        public double GetResultFieldValue()
        {
            double res;
            if (double.TryParse(this.ResultField.Text, out res))
            {
                return res;
            }
            else
            {
                return double.MinValue;
            }
        }

        public CalculatorPanelPageObject PressAdd()
        {
            Mouse.Click(this.AddButton);
            return this;
        }

        public CalculatorPanelPageObject PressSubtract()
        {
            Mouse.Click(this.SubtractButton);
            return this;
        }

        public CalculatorPanelPageObject PressMultiply()
        {
            Mouse.Click(this.MultiplyButton);
            return this;
        }

        public CalculatorPanelPageObject PressDivide()
        {
            Mouse.Click(this.DivideButton);
            return this;
        }
    }
}
