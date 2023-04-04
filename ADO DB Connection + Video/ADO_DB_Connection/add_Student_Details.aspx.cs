using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace ADO_DB_Connection
{
    public partial class add_Student_Details : System.Web.UI.Page
    {
        string gender;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7VOIT30\\SQLEXPRESS;Initial Catalog=SDetails;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT [SName]\r\n      ,[FName]\r\n      ,[MName]\r\n      ,[Age]\r\n      ,[Class]\r\n      ,[Gender]\r\n  FROM [dbo].[StudentDetails]", con);
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7VOIT30\\SQLEXPRESS;Initial Catalog=SDetails;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[StudentDetails]
           ([SName]
           ,[FName]
           ,[MName]
           ,[Age]
           ,[Class]
           ,[Gender])
     VALUES
           ('"+TextBox1.Text+"','"+TextBox2.Text +"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+gender+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Student Details Added successfully')</script>");

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string name=TextBox1.Text;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            string fname=TextBox2.Text;
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            string mname=TextBox3.Text;
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            string age=TextBox4.Text;
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            string stuclass=TextBox5.Text;
        }
    }
}