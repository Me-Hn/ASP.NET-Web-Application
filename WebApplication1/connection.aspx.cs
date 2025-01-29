using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class connection : System.Web.UI.Page
    {
        string connstring = "Data Source=DESKTOP-QOSO84J\\SQLEXPRESS01;Initial Catalog=office;Integrated Security=True";

        public void fetchData()
        {
            SqlConnection conn = new SqlConnection(connstring);

            string _data = "select * from student"; 
            SqlDataAdapter adapter = new SqlDataAdapter(_data,conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fetchData();
            }
        }


        //insert Data
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstring);

            string val1 = TextBox1.Text;
            string val2 = TextBox2.Text;

            string query = "insert into student (name , email) VALUES ('" + val1 + "', '" + val2 + "')";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Response.Write("insert Record");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }


        }
        //insert Data End

        //update Data
        


        //update Data End

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Retrieve the primary key of the row to be deleted
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);


            // Perform the delete operation
            SqlConnection conn = new SqlConnection(connstring);

            string deleteQuery = "DELETE FROM student WHERE id = @id";
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);

                // Use parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            

            // Rebind the GridView to refresh the data
            fetchData();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex].Value);
            Response.Redirect($"Editpage.aspx?id={id}");

            //Response.Redirect($"Edit.aspx?id={id}");

            SqlConnection conn = new SqlConnection(connstring);

            string update_data = "UPDATE Users SET name = @Name, email = @Email WHERE id = @Id;";
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}