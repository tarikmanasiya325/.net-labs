using System;
using System.Web.UI;

namespace Event_registration_form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Disables jQuery dependency for validators
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string fullName = TextBox1.Text;
                string email = TextBox2.Text;
                string mobileNumber = TextBox3.Text;
                string gender = RadioButtonList1.SelectedValue;
                string selectedEvent = DropDownList1.SelectedValue;
                string eventDate = TextBox5.Text;
                string address = TextBox4.Text;

                string script = $"alert('Registration Successful for {fullName.Replace("'", "\\'")}!');";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessAlert", script, true);
            }
        }
    }
}