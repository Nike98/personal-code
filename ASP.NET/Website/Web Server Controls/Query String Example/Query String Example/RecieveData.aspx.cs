using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Query_String_Example
{
    public partial class RecieveData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Name"] == "" && Request.QueryString["Email"] == "")
                lblName.Text = "No Data recieved from the Page at all.";
            else if (Request.QueryString["Email"] == "")
                lblName.Text = "No Data of Email recieved from the Page.";
            else if (Request.QueryString["Name"] == "" )
                lblName.Text = "No Data of Name recieved from the Page.";
            else
            {
                lblName.Text = "Your Name : " + Request.QueryString["Name"].ToString();
                lblEmail.Text = "Your Email : " + Request.QueryString["Email"].ToString();
            }
        }
    }
}