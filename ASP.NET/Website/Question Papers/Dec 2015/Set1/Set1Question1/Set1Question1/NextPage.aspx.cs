using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Set1Question1
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If the User logged in Sccessfully Start a Session
            if (Session["loggedIn"] != null)
            {
                // Request the created Cookies
                HttpCookie cookie = Request.Cookies["name"];
                if (cookie != null)
                    lblDisplay.Text = "You are logged in as " + cookie.Value;
                else
                    // If the User is not logged in then Redirect to the Login page
                    Response.Redirect("Default.aspx?qrstr=Direct access not allowed");
            }
        }
    }
}