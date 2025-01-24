using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class connection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=DESKTOP-QOSO84J\\SQLEXPRESS01;Initial Catalog=office;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);

            string val1 = TextBox1.Text;
            string val2 = TextBox2.Text;

            string query = "insert into office (name , email) VALUES ('" + val1 + "', '" + val2 + "')";

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
    }
}