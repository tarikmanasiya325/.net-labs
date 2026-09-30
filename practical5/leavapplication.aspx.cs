using System;
using System.Web;

namespace practical5
{
    public partial class leavapplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve employee name from cookie if present
                if (Request.Cookies["empname"] != null)
                {
                    texttemp.Text = Request.Cookies["empname"].Value;
                    CheckBox1.Checked = true;
                }

                // Retrieve selected date from Session
                if (Session["leaveDate"] != null)
                {
                    DateTime lvdate = (DateTime)Session["leaveDate"];
                    leavedate.Text = lvdate.ToString("dd-MM-yyyy");
                }
                else
                {
                    leavedate.Text = "Date Not Selected";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string empnm = texttemp.Text;
            string leaveType = DropDownList1.SelectedValue;
            string reason = TextBox2.Text;

            // Store application details in Session
            Session["empname"] = empnm;
            Session["leaveType"] = leaveType;
            Session["Reason"] = reason;

            // Persistent Cookie Management
            if (CheckBox1.Checked)
            {
                // Create or overwrite persistent cookie if checkbox is checked
                HttpCookie nameCookie = new HttpCookie("empname", empnm);
                nameCookie.Expires = DateTime.Now.AddDays(8);
                Response.Cookies.Add(nameCookie);
            }
            else
            {
                // Clear existing cookie if checkbox is left unchecked
                if (Request.Cookies["empname"] != null)
                {
                    HttpCookie nameCookie = new HttpCookie("empname");
                    nameCookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(nameCookie);
                }
            }

            Label2.Text = "<b>Leave Applied Successfully</b><br /><br />" + empnm + ", your leave request has been submitted.";
        }
    }
}
