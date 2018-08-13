using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Addition
{
    public partial class AdditionOf2Nos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txb1.Text);
            int num2 = Convert.ToInt32(txb2.Text);

            int ans = num1 + num2;

            lblAns.Text = Convert.ToString(ans);
        }
    }
}