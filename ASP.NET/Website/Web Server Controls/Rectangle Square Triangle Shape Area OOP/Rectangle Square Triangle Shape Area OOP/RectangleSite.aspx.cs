using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rectangle_Square_Triangle_Shape_Area_OOP
{
    public partial class RectangleSite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(Convert.ToDouble(txbLength.Text), Convert.ToDouble(txbBreadth.Text));
            lblAnswer.Text = "Area of the Rectangle = " + rect.CalcArea().ToString();
            txbLength.Text = txbBreadth.Text = "";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}