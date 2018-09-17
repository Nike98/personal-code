using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Read_or_Write_Cookies
{
    public partial class WriteCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            // Creating a new Cookie by passing the 
            // value to the constructor of HttpCookie.
            HttpCookie cookie = new HttpCookie(txbName.Text);
            // Setting the Value of the Cookie
            cookie.Value = txbValue.Text;
            // Set the Expiration time of the Cookie
            DateTime currDt = DateTime.Now;
            TimeSpan tspan = new TimeSpan(0, 0, 1, 0);
            // Assign the Expiration time
            cookie.Expires = currDt + tspan;

            // Add the cookie
            Response.Cookies.Add(cookie);
            Response.Write("Cookie Written Successfully. <br><hr>");
        }
    }
}