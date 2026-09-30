<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leavapplication.aspx.cs" Inherits="practical5.leavapplication" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Application</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>FACULTY OF ENGINEERING AND TECHNOLOGY</h3>
            <h4>Department of Computer Science and Engineering</h4>
            <p>01CE1523 - .NET Technologies | Tarikhushen manasiya (92400120026) | BATCH: A</p>
            <hr />

            <h2>Leave Application</h2>
            Employee Name: <asp:TextBox ID="texttemp" runat="server"></asp:TextBox>
            <br /><br />
            
            Leave Date: <asp:Label ID="leavedate" runat="server" Text="Not Selected"></asp:Label>
            <br /><br />
            
            Leave Type: 
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="Casual Leave" Value="Casual Leave" Selected="True" />
                <asp:ListItem Text="Medical Leave" Value="Medical Leave" />
                <asp:ListItem Text="Family Emergency" Value="Family Emergency" />
                <asp:ListItem Text="Child's PTM" Value="Child's PTM" />
            </asp:DropDownList>
            <br /><br />
            
            Reason: <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
            <br /><br />
            
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember My Name" />
            <br /><br />
            
            <asp:Button ID="Button1" runat="server" Text="Submit Application" OnClick="Button1_Click" />
            <br /><br />
            
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
