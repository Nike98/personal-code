using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtonList
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void btnSelection_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "You have Selected: " + RdBtnLs1.SelectedItem.Text;
        }
    }
}