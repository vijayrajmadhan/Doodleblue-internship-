<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_form.aspx.cs" Inherits="Custom_Validation_Controls.login_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .sign{
            padding-left:10%;
            padding-right:30%;
            margin:25px 50px 75px 100px;
            padding-bottom:20%;
            padding-top:10%;
            background-color:rebeccapurple;
        }
        .auto-style1 {
            width: 554px;
            border: 2px solid #FF9900;
            background-color: #FFFF00;  
        }
        .auto-style3 {
            width: 258px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 359px;
        }
        .auto-style8 {
            height: 54px;
        }
        .auto-style9 {
            height: 8px;
            width: 359px;
        }
        .auto-style14 {
            width: 258px;
        }
        .auto-style15 {
            height: 10px;
            width: 359px;
        }
        .auto-style16 {
            height: 10px;
            width: 258px;
        }
        .auto-style17 {
            height: 8px;
            width: 258px;
        }
        .auto-style18 {
            width: 359px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="sign">
            <table class="auto-style1">
                <tr style="text-align:center;font-weight:bold;">
                    <td colspan="2" >Signup Form</td>
                </tr>
                <tr style="text-align:center;">
                    <td class="auto-style14">User-ID</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None"></asp:TextBox>
                    </td>
                </tr>
                <tr style="text-align:center;">
                    <td class="auto-style14">Password</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="TextBox2" runat="server" BorderStyle="None"></asp:TextBox>
                    </td>
                </tr>
                <tr style="text-align:center;">
                    <td class="auto-style3">Confirm Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox3" runat="server" BorderStyle="None"></asp:TextBox>
                    </td>
                </tr>
                <tr style="text-align:center;">
                    <td class="auto-style14">Age</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="TextBox4" runat="server" BorderStyle="None"></asp:TextBox>
                    </td>
                </tr>
                <tr style="text-align:center;">
                    <td class="auto-style3">Email-ID</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox5" runat="server" BorderStyle="None"></asp:TextBox>
                    </td>
                </tr>
                <tr style="text-align:center;">
                    <td class="auto-style8" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Submit" Height="33px" Width="65px" />
                        <asp:CustomValidator ID="CustomValidator5" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="enter the correct email" ForeColor="Red" OnServerValidate="CustomValidator5_ServerValidate" SetFocusOnError="True">Email is not Correct</asp:CustomValidator>
                    </td>
                </tr>
                <tr style="text-align:center;">
                    <td class="auto-style16">
                        <asp:CustomValidator ID="CustomValidator1" runat="server" BorderStyle="None" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Enter the UserId" ForeColor="Red" Height="16px" OnServerValidate="CustomValidator1_ServerValidate" SetFocusOnError="True" ValidateEmptyText="True" Width="256px">UserID need to Entered</asp:CustomValidator>
                    </td>
                    <td class="auto-style15">
                        <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Password is incorrect" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate" SetFocusOnError="True">Password Should need to be 8 to 15 characters,should contain one (special  character,upper Case,Numeric value)</asp:CustomValidator>
                    </td>
                </tr>
                <tr style="text-align:center;">
                    <td class="auto-style17">
                        <asp:CustomValidator ID="CustomValidator3" runat="server" BorderStyle="None" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="confirm password need to be equal" ForeColor="Red" OnServerValidate="CustomValidator3_ServerValidate" SetFocusOnError="True">Entered Value is not Equal to Pasword</asp:CustomValidator>
                    </td>
                    <td class="auto-style9">
                        <asp:CustomValidator ID="CustomValidator4" runat="server" BorderStyle="None" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="age should need to number" ForeColor="Red" OnServerValidate="CustomValidator4_ServerValidate" SetFocusOnError="True">Age should need to be Numeric and  age should between 18 to 60</asp:CustomValidator>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
