using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Custom_Validation_Controls
{
    public partial class login_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string userid;
            userid = TextBox1.Text;
            if (!string.IsNullOrWhiteSpace(userid))
            {
                args.IsValid = true;
                CustomValidator1.Text = null;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string password;
            password = TextBox2.Text;
            if (!string.IsNullOrWhiteSpace(password) && password.Any(char.IsUpper) && password.Length >= 8 && password.Length <= 15 && password.Any(char.IsDigit))
            {
                args.IsValid = true;
                CustomValidator2.Text = null;
            }
            else
            {
               args.IsValid = false;
            }
           
        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string confirm_password;
            confirm_password = TextBox3.Text;
            if (!string.IsNullOrWhiteSpace(confirm_password) && confirm_password.Equals(TextBox2.Text))
            {
                args.IsValid = true;
                CustomValidator3.Text = null;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void CustomValidator4_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string age;
            
            age = TextBox4.Text;
            if(!string.IsNullOrWhiteSpace(age) && age.All(char.IsDigit))
            {
                args.IsValid = true;
                CustomValidator4.Text = null;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void CustomValidator5_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (TextBox5.Text.EndsWith("."))
            {
                args.IsValid= false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(TextBox5.Text);
                args.IsValid = true;
                CustomValidator5.Text = null;
            }
            catch
            {
                args.IsValid=false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text) || string.IsNullOrEmpty(TextBox3.Text) || string.IsNullOrEmpty(TextBox4.Text) || string.IsNullOrEmpty(TextBox5.Text))
            {
                Response.Write("<script>alert('Values need to be Entered')</script>");
            }
            else
            {
                if(!string.IsNullOrEmpty(CustomValidator1.Text) || !string.IsNullOrEmpty(CustomValidator2.Text) || !string.IsNullOrEmpty(CustomValidator3.Text) || !string.IsNullOrEmpty(CustomValidator4.Text) || !string.IsNullOrEmpty(CustomValidator5.Text))
                {
                    Response.Write("<script>alert('Enter the value correctly')</script>");
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-7VOIT30\\SQLEXPRESS;Initial Catalog=Singup;Integrated Security=True");
                    string sql = @"INSERT INTO [dbo].[details]
                             ([username]
                             ,[pasword]
                             ,[confirm_password]
                             ,[age]
                             ,[Email])
                             VALUES
                                     ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Resister Successfully");
                    
                    Response.Write("<script>alert('Signup Completed')</script>");
                }
                
            }
           
        }
    }
}