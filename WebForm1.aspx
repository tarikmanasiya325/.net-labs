<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Event_registration_form.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Event Registration Form</title>
    <style type="text/css">
        .auto-style1 { width: 100%; }
        .auto-style2 { width: 521px; }
        .auto-style3 { height: 26px; }
        .auto-style4 { width: 521px; height: 26px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <!-- Full Name Row -->
            <tr>
                <td>Full Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="Enter name" ForeColor="#CC0000">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>

            <!-- Email Row -->
            <tr>
                <td>Email</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Email"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="Enter email address" ForeColor="Red" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionVali1" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="Valid Email required" 
                        ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" ForeColor="Red" Display="Dynamic">
                    </asp:RegularExpressionValidator>
                </td>
            </tr>

            <!-- Mobile Number Row -->
            <tr>
                <td>Mobile Number</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server" 
                        ControlToValidate="TextBox3" ErrorMessage="Enter phone number" ForeColor="Red" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionVali2" runat="server" 
                        ControlToValidate="TextBox3" ErrorMessage="Enter valid 10-digit phone number" 
                        ValidationExpression="^(\+91)?[6-9]\d{9}$" ForeColor="Red" Display="Dynamic">
                    </asp:RegularExpressionValidator>
                </td>
            </tr>

            <!-- Gender Row -->
            <tr>
                <td>Gender</td>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="24px" Width="91px">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorGender" runat="server" 
                        ControlToValidate="RadioButtonList1" ErrorMessage="Please select gender" ForeColor="#CC0000">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>

            <!-- Event Selection Row -->
            <tr>
                <td class="auto-style3">Event</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="">-- Select Event --</asp:ListItem>
                        <asp:ListItem>AI Workshop</asp:ListItem>
                        <asp:ListItem>ML Workshop</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEvent" runat="server" 
                        ControlToValidate="DropDownList1" InitialValue="" ErrorMessage="Please select one event" ForeColor="#FF6666">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>

            <!-- Date Row -->
            <tr>
                <td class="auto-style3">Date</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDate" runat="server" 
                        ControlToValidate="TextBox5" ErrorMessage="Event date is required" ForeColor="#CC0000">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>

            <!-- Address Row -->
            <tr>
                <td>Address</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server" 
                        ControlToValidate="TextBox4" ErrorMessage="Please enter your address" ForeColor="#FF5050">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>

            <!-- Submit Button Row -->
            <tr>
                <td>Register</td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>

            <!-- Validation Summary Row -->
            <tr>
                <td colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        HeaderText="Please Fix the Error:" ShowMessageBox="True" ShowSummary="False" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>