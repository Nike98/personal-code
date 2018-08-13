using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arithmetic_Operations
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txb1.Text);
            int num2 = Convert.ToInt32(txb2.Text);

            // Addition
            lblAdd.Text = "The Addition is : " + Convert.ToString(num1 + num2);

            // Subtraction
            lblSub.Text = "The Subtraction is : " + Convert.ToString(num1 - num2);

            // Multipication
            lblMul.Text = "The Multipication is : " + Convert.ToString(num1 * num2);

            // Division
            lblDiv.Text = "The Division is : " + Convert.ToString(num1 / num2);

            // Modulus
            lblMod.Text = "The Modulus is : " + Convert.ToString(num1 % num2);
        }
    }
}