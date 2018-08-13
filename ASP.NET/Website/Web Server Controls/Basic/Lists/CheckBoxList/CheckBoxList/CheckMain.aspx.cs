using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckBoxList
{
    public partial class CheckMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            String selec = "";

            for (int i = 0; i < chboxls.Items.Count; i++)
            {
                if (chboxls.Items[i].Selected)
                    selec += chboxls.Items[i].Text + "<br />";
            }

            lblDisplay.Text = selec;
            lblDisplay.ForeColor = System.Drawing.Color.Green;
            lblDisplay.BorderColor = System.Drawing.Color.Red;
        }
    }
}