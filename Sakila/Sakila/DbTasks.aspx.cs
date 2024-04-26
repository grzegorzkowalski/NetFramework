using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sakila
{
    public partial class DbTasks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListCategories.DataSource = Db.GetData("SELECT category_id, name FROM category");
                DropDownListCategories.DataBind();
            }
        }

        protected void DropDownListCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryName.Text = DropDownListCategories.SelectedItem.Text;
        }
    }
}