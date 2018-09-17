using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Read_or_Write_Cookies
{
    public partial class ReadCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Initally checking if the incoming QueryString is not null
            // If it has some Values then proceed
            if (Request.QueryString["cookie"] != null)
                MethodReadCookie();
        }

        protected void MethodReadCookie()
        {
            // Get the name of the Cookie entered by the User
            string CookieName = Request.QueryString["cookie"].ToString();

            // Grab the Cookie
            HttpCookie cookie = Request.Cookies[CookieName];

            // Check if the Cookie Exists
            if (cookie == null)
                lblCookie.Text = "Cookie not found. <br><hr>";
            else
            {
                // If the Cookie is found 
                // Print the Value of the Cookie
                string CookieValue = cookie.Value.ToString();
                lblCookie.Text = "The " + CookieName + " cookie contains: <b>" + CookieValue + "</b><br><hr>";
            }

        }
    }
}