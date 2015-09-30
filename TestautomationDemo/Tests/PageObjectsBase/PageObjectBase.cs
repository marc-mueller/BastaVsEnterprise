using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectsBase
{
    public class PageObjectBase
    {
        public UITestControl ParentControl { get; internal set; }

        public PageObjectBase(UITestControl parentControl)
        {
            this.ParentControl = parentControl;
        }

        public TControl FindControlById<TControl>(string id) where TControl : UITestControl
        {
            TControl searchControl = Activator.CreateInstance(typeof(TControl), this.ParentControl) as TControl;

            if (typeof(TControl).IsSubclassOf(typeof(WpfControl)))
            {
                searchControl.SearchProperties.Add(WpfControl.PropertyNames.AutomationId, id);
            }
            else if (typeof(TControl).IsSubclassOf(typeof(WinControl)))
            {
                searchControl.SearchProperties.Add(WinControl.PropertyNames.Name, id);
            }
            else if (typeof(TControl).IsSubclassOf(typeof(HtmlControl)))
            {
                searchControl.SearchProperties.Add(HtmlControl.PropertyNames.Id, id);
            }

            return searchControl;
        }
    }
}
