using Microsoft.VisualStudio.TestTools.UITesting;
using PageObjectsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorWeb.UITests.PageObjects
{
    public class SimpleCalculatorBrowser : BrowserPageObjectBase
    {
        private CalculatorPanelPageObject calculatorPanel;

        private SimpleCalculatorBrowser() : base()
        {

        }

        public static SimpleCalculatorBrowser Launch(Uri uri = null, string browser = "IE")
        {
            if (uri == null)
            {
                uri = new Uri("http://localhost:12115");          }

            var app = new SimpleCalculatorBrowser();
            app.Start(uri, browser);
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
