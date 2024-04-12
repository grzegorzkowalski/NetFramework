using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class LifeCycle : System.Web.UI.Page
    {
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Debug.WriteLine("Page_PreLoad");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Debug.WriteLine("Page_Init");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Page_Load");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Debug.WriteLine("Page_PreRender");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            Debug.WriteLine("Page_Unload");
        }
    }
}