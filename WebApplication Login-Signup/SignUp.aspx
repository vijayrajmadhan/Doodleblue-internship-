<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication_Login_Signup.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 402px;
            height: 147px;
        }
        .auto-style2 {
            height: 240px;
        }
    </style>
</head>
<body style="height: 254px">
    <form id="form1" runat="server">
        <div align="center" class="auto-style2">
            <h2>SignUp Form</h2>
            <table class="auto-style1">
                 <tr>
                     <td>
                         <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>                     
                     </td>
                     <td>
                         <asp:TextBox ID="TextBox1" runat="server" Width="227px"></asp:TextBox>
                     </td>
                 </tr>
                <tr>
                     <td>
                         <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>                     
                     </td>
                     <td>
                         <asp:TextBox ID="TextBox2" runat="server" Width="227px"></asp:TextBox>
                     </td>
                 </tr>
                <tr>
                     <td>
                         <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>                     
                     </td>
                     <td>
                         <asp:TextBox ID="TextBox3" runat="server" Width="227px"></asp:TextBox>
                     </td>
                 </tr>
                <tr>
                     <td>
                         <asp:Label ID="Label4" runat="server" Text="Mobile No"></asp:Label>                     
                     </td>
                     <td>
                         <asp:TextBox ID="TextBox4" runat="server" Width="227px"></asp:TextBox>
                     </td>
                 </tr>
            </table>
            <asp:Button ID="Button1" runat="server" Height="32px" OnClick="Button1_Click" Text="SignUp" />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Already Have an account?</asp:LinkButton>
        </div>
    </form>
</body>
</html>
