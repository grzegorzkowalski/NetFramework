using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Sakila
{
    public partial class ListActors : System.Web.UI.Page
    {
        public String firstName = "Imię";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindActors();
            }
        }

        private void BindActors()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM actor", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridViewActors.DataSource = dt;
                GridViewActors.DataBind();
            }
        }

        protected void GridViewActors_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewActors.EditIndex = e.NewEditIndex;
            BindActors();
        }

        protected void GridViewActors_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Retrieve key and new value(s)
            int id = Convert.ToInt32(((String)GridViewActors.Rows[e.RowIndex].Cells[0].Text));
            string newName = ((TextBox)GridViewActors.Rows[e.RowIndex].Cells[2].Controls[0]).Text;

            // Update the data source
            UpdateData(id, newName);

            // Reset the edit index and rebind data
            GridViewActors.EditIndex = -1;
            BindActors();
        }

        private void UpdateData(int id, string newName)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE actor SET last_name = @NewName WHERE actor_id = @ActorId", con);
                cmd.Parameters.AddWithValue("@NewName", newName);
                cmd.Parameters.AddWithValue("@ActorId", id);

                cmd.ExecuteNonQuery();
            }
        }

        protected void GridViewActors_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(((String)GridViewActors.Rows[e.RowIndex].Cells[0].Text));
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM actor WHERE actor_id = @ActorId", con);
                cmd.Parameters.AddWithValue("@ActorId", id);
                cmd.ExecuteNonQuery();
            }

            BindActors();
        }

        protected void GridViewActors_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // Fetch new values from the GridView and update the database
            // Similar to the btnAddActor_Click logic but using UPDATE SQL command
        }
    }
}