using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectsBase
{
    public class ApplicationPageObjectBase : PageObjectBase
    {
        public ApplicationPageObjectBase() : base(null)
        {

        }

        public ApplicationPageObjectBase Start(string filename)
        {
            this.ParentControl = ApplicationUnderTest.Launch(filename);
            return this;
        }
    }
}
