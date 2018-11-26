using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rectangle_Square_Triangle_Shape_Area_OOP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rdbtnSquare_CheckedChanged(object sender, EventArgs e)
        {
            Response.Redirect("SquareSite.aspx");
        }

        protected void rdbtnRectangle_CheckedChanged(object sender, EventArgs e)
        {
            Response.Redirect("RectangleSite.aspx");
        }

        protected void rdbtnTriangle_CheckedChanged(object sender, EventArgs e)
        {
            Response.Redirect("TriangleSite.aspx");
        }
    }
}