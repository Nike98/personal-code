using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rectangle_Square_Triangle_Shape_Area_OOP
{
    public partial class TriangleSite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            Triangle tri = new Triangle(Convert.ToDouble(txbBreadth.Text), Convert.ToDouble(txbHeight.Text));
            lblAnswer.Text = "Area of the Triangle = " + tri.CalcArea().ToString();
            txbBreadth.Text = txbHeight.Text = "";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}