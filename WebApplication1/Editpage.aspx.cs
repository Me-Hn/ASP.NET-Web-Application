using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Editpage : System.Web.UI.Page
    {
        string connstring = "Data Source=DESKTOP-QOSO84J\\SQLEXPRESS01;Initial Catalog=office;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);

                    using (SqlConnection conn = new SqlConnection(connstring))
                    {
                        conn.Open();
                        string selectQuery = "SELECT name, email FROM student WHERE id = @Id";
                        SqlCommand cmd = new SqlCommand(selectQuery, conn);
                        cmd.Parameters.AddWithValue("@Id", id);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblID.Text = "Editing User ID: " + id;
                            txtName.Text = reader["name"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                        }
                    }
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                string name = txtName.Text;
                string email = txtEmail.Text;

                //string connstring = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    string updateQuery = "UPDATE student SET name = @Name, email = @Email WHERE id = @Id";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                lblMessage.Text = "User updated successfully!";
            }
        }

    }
}