using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Adrotator_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AdRotator_Ad(object sender, AdCreatedEventArgs e)
        {
            e.NavigateUrl = "https://github.com/Nike98/personal-code";
        }
    }
}