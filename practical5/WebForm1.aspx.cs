using System;

namespace practical5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectdt = Calendar1.SelectedDate;
            Label1.Text = "You have selected: " + selectdt.ToString("dd-MM-yyyy");
            Session["leaveDate"] = selectdt;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("leavapplication.aspx");
        }
    }
}
