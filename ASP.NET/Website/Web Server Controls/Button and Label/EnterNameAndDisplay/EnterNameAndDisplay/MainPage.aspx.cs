using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterNameAndDisplay
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hplink1.Text = "This is a HyperLink";
            hplink1.NavigateUrl = "https://msdn.microsoft.com/en-us/library/e75sxasw(v=vs.85).aspx";
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {

            lblDisplay.Text = "Welcome " + txbName.Text + " to your First ASP.NET Page";

        }
    }
}