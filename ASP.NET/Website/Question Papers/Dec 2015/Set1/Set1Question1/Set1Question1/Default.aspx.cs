using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Set1Question1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = Request.QueryString["qrstr"];
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbName.Text == "usName" && txbPassword.Text == "1234"){
                // Create Cookie and Add it
                HttpCookie cookieName = new HttpCookie("name", txbName.Text);
                Response.Cookies.Add(cookieName);

                // Create a Session
                Session["loggedIn"] = txbName.Text;
                Response.Redirect("NextPage.aspx");
            }
            else if(txbName.Text == "" || txbPassword.Text == "")
            {
                lblMsg.Text = "One or more fields are empty";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblMsg.Text = "Username or Password did not match";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}