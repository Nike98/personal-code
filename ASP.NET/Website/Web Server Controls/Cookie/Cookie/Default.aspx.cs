using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStatus.Text = Request.QueryString["qrstr"];
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUid.Text == "1234" && txbPass.Text == "nikhil")
            {
                // Create Cookie and Add it
                HttpCookie cookie = new HttpCookie("uid", txbUid.Text);
                Response.Cookies.Add(cookie);

                // Create a Session
                Session["loggedIn"] = txbUid.Text;
                Response.Redirect("Profile.aspx");
            }
            else if(txbUid.Text == "" || txbPass.Text == "")
            {
                lblStatus.Text = "One or more fields are empty";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblStatus.Text = "Username or Password did not match";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}