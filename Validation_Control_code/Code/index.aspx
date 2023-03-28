<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Validation_Controls.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        User ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 26px" Width="149px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="UserID is madatoryr" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 26px" Width="149px"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Invalid Pssword" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" SetFocusOnError="True" ValidateEmptyText="True">Password need to be  8 to 15</asp:CustomValidator>
        <br />
        <br />
        Confirm Password<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 26px" Width="149px"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="Password not Same" ForeColor="Red" SetFocusOnError="True">Password not Same</asp:CompareValidator>
        <br />
        <br />
        Email Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 26px" Width="149px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Email ID is Incorrect" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Invalid Email</asp:RegularExpressionValidator>
        <br />
        <br />
        Mobile User&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 26px" Width="149px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="Incorrect Mobile Number" ForeColor="Red" ValidationExpression="\d{10}">Mobile is Incorrect</asp:RegularExpressionValidator>
        <br />
        <br />
        DOB&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 26px" Width="149px"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="Age must be in between 18 to 45" ForeColor="Red" Type="Date">Age must be in between 18 to 45</asp:RangeValidator>
        <br />
        <br />
        Country&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="153px">
            <asp:ListItem Text="Select the Country"></asp:ListItem>
            <asp:ListItem Value="India">India</asp:ListItem>
            <asp:ListItem Value="USA">USA</asp:ListItem>
            <asp:ListItem Value="Australia">Australia</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1" Display="Dynamic" ErrorMessage="Country Need to be Selected" ForeColor="Red" InitialValue="Select the Country" SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
    </form>
</body>
</html>
