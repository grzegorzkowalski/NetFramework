using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate ListBox
                lstItems.Items.Add(new ListItem("Course 1", "1"));
                lstItems.Items.Add(new ListItem("Course 2", "2"));
                lstItems.Items.Add(new ListItem("Course 3", "3"));
                lstItems.Items.Add(new ListItem("Course 4", "4"));
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (ListItem item in lstItems.Items)
            {
                if (item.Selected)
                {
                    text += item.Text + "<br/>";
                }
            }
            Literal1.Text = $"<div>" +
                $"<h1>{FirstName.Text} {LastName.Text}</h1>" +
                $"<h2>{FacultyNumber.Text}</h2>" +
                $"<p>{University.SelectedItem}</p>" +
                $"<p>{Speciality.SelectedItem}</p>" +
                $"<p>{text}</p>" +
                $"</div>";
        }
    }
}