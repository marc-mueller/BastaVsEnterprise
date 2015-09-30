using Microsoft.VisualStudio.TestTools.UITesting;
using PageObjectsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorWpf.UITests.PageObjects
{
    public class SimpleCalculatorApp : ApplicationPageObjectBase
    {
        private CalculatorPanelPageObject calculatorPanel;

        private SimpleCalculatorApp() : base()
        {

        }

        public static SimpleCalculatorApp Launch(string file = null)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                file = @"D:\Work\Repos\BastaVsEnterprise\TestautomationDemo\SimpleCalculatorWpf\bin\Debug\SimpleCalculatorWpf.exe";
            }

            var app = new SimpleCalculatorApp();
            app.Start(file);
            return app;
        }

        public CalculatorPanelPageObject CalculatorPanel
        {
            get
            {
                if (this.calculatorPanel == null)
                {
                    this.calculatorPanel = new CalculatorPanelPageObject(this.ParentControl);
                }
                return this.calculatorPanel;
            }

        }
    }
}
