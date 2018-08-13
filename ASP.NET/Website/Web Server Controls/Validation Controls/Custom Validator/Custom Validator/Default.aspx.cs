using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Custom_Validator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {

        }

        protected void UserIdCustomValidate(object source, ServerValidateEventArgs args)
        {
            string str = args.Value;
            args.IsValid = false;

            // Checking if the Lenght of the input is greater than 5 and less than 26 characters
            if (str.Length > 6 || str.Length < 25)
                return;

            // Checking if the input has at least one Capital Letter
            bool capital = false;

            foreach (char ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    capital = true;
                    break;
                }

                if (!capital)
                    return;
            }

            // Checking if the input has at least one Lower Letter
            bool lower = false;

            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    lower = true;
                    break;
                }

                if (!lower)
                    return;
            }

            // Checking if the input has at least one Digit
            bool digit = false;

            foreach (char ch in str)
            {
                if (ch >= '0' && ch <= '9')
                {
                    digit = true;
                    break;
                }

                if (!digit)
                    return;
            }

            args.IsValid = true;
        }
    }
}