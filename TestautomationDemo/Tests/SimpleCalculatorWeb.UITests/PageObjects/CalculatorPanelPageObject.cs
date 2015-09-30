using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using PageObjectsBase;

namespace SimpleCalculatorWeb.UITests.PageObjects
{
    public class CalculatorPanelPageObject : PageObjectBase
    {
        private HtmlEdit firstNumberField;
        private HtmlEdit secondNumberField;
        private HtmlEdit resultField;
        private HtmlButton addButton;
        private HtmlButton subtractButton;
        private HtmlButton multiplyButton;
        private HtmlButton divideButton;

        public CalculatorPanelPageObject(UITestControl parentControl) : base(parentControl)
        {

        }

        public HtmlEdit FirstNumberField
        {
            get
            {
                if (firstNumberField == null)
                {
                    firstNumberField = FindControlById<HtmlEdit>("SimpleCalculatorTxtFirstNumber");
                }
                return firstNumberField;
            }
        }

        public HtmlEdit SecondNumberField
        {
            get
            {
                if (secondNumberField == null)
                {
                    secondNumberField = FindControlById<HtmlEdit>("SimpleCalculatorTxtSecondNumber");
                }
                return secondNumberField;
            }
        }

        public HtmlEdit ResultField
        {
            get
            {
                if (resultField == null)
                {
                    resultField = FindControlById<HtmlEdit>("SimpleCalculatorTxtResult");
                }
                return resultField;
            }
        }

        public HtmlButton AddButton
        {
            get
            {
                if (addButton == null)
                {
                    addButton = FindControlById<HtmlButton>("SimpleCalculatorBtnAdd");
                }
                return addButton;
            }
        }

        public HtmlButton SubtractButton
        {
            get
            {
                if (subtractButton == null)
                {
                    subtractButton = FindControlById<HtmlButton>("SimpleCalculatorBtnSubtract");
                }
                return subtractButton;
            }
        }

        public HtmlButton MultiplyButton
        {
            get
            {
                if (multiplyButton == null)
                {
                    multiplyButton = FindControlById<HtmlButton>("SimpleCalculatorBtnMultiply");
                }
                return multiplyButton;
            }
        }

        public HtmlButton DivideButton
        {
            get
            {
                if (divideButton == null)
                {
                    divideButton = FindControlById<HtmlButton>("SimpleCalculatorBtnDivide");
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
