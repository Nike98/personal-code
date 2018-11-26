using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If the User has Logged in correctly, Start the Session
            if (Session["loggedIn"] != null)
            {
                // Request for the created Cookies
                HttpCookie cookie = Request.Cookies["uid"];
                if (cookie != null)
                    lblMsg.Text = "Welcome " + cookie.Value;
                else
                    // If the User is not logged in then Redirect to the Login page
                    Response.Redirect("Default.aspx?qrstr=Direct access not allowed");
            }
        }
    }
}