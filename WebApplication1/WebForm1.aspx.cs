using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//to access sql server
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new
                SqlConnection(@"initial catalog = ADOdemo ; data source = CGI-JAVA-055\CGI ;integrated security = true");

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from users", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "t1");
            DataTable dt = ds.Tables["t1"];
            string user = TextBox1.Text;
            string pass = TextBox2.Text;
            DataRow fr = dt.Rows[0];
            bool login = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fr = dt.Rows[i];
                if (fr[0].ToString() == user && fr[1].ToString() == pass)
                {
                    login = true;
                    break;
                }
            }
            if(login)
            {
                Response.Write("Login Successfull");
            }
            else
            {
                Response.Write("Login Failed");
            }
        }
    }
}