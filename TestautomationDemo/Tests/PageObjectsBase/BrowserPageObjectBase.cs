using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectsBase
{
    public class BrowserPageObjectBase : PageObjectBase
    {
        public BrowserPageObjectBase() : base(null)
        {

        }

        public BrowserPageObjectBase Start(Uri uri, string browser = "IE")
        {
            BrowserWindow.CurrentBrowser = browser;
            this.ParentControl = BrowserWindow.Launch(uri);
            return this;
        }
    }
}
