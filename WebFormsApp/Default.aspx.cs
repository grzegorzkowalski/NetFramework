﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello, ASP.NET from Code-behind!");
        }
    }
}