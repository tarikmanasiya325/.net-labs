<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practical5.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Academic Calendar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>FACULTY OF ENGINEERING AND TECHNOLOGY</h3>
            <h4>Department of Computer Science and Engineering</h4>
            <p>01CE1523 - .NET Technologies | Tarikhushen manasiya (92400120026) | BATCH: A</p>
            <hr />
            
            <h2>Academic Calendar</h2>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br /><br />
            
            <asp:Label ID="Label1" runat="server" Text="Please select a date from the calendar."></asp:Label>
            <br /><br />
            
            <asp:Button ID="Button1" runat="server" Text="Apply for Leave" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
