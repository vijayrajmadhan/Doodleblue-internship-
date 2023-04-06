using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication_Login_Signup
{
    public partial class LogIn : System.Web.UI.Page
    {
        readonly SqlCommand cmd=new SqlCommand();
        readonly SqlConnection con=new SqlConnection();
        SqlDataAdapter sda=new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            con.ConnectionString = "Data Source=DESKTOP-7VOIT30\\SQLEXPRESS;Initial Catalog=WebLogin;Integrated Security=True";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from SignUp Where UserName='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "' ";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "SignUp");
            if (ds.Tables[0].Rows.Count > 0 )
            {
                Session["data"] = TextBox1.Text;
                Response.Redirect("Home.aspx");
            }
            else
            {
                Label3.Text = "Wrong user name or password";
            }

        }
    }
}