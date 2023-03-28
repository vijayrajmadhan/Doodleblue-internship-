using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

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
            }
            catch
            {
                args.IsValid=false;
            }
        }
    }
}