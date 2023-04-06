<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebApplication_Login_Signup.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 164px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" class="auto-style1">
            <h2>LogIn</h2>
            <table>
                <tr>
                    <td> 
                        <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
                    </td>
                    <td> 
                        <asp:TextBox ID="TextBox1" runat="server" Width="109px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td> 
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td> 
                        <asp:TextBox ID="TextBox2" runat="server" Width="109px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
