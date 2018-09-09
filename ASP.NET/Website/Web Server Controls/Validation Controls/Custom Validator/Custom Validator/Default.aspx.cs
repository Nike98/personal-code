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
            //checking for input length greater than 6 and less than 25 characters
            if (str.Length < 6 || str.Length > 25)
            {
                UidCustomValidate.ErrorMessage = " length kam hai ";
                return;
            }
            //checking for a atleast a single capital letter
            bool capital = false;
            foreach (char ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    capital = true;
                    break;
                }
            }
            if (!capital)
            {
                UidCustomValidate.ErrorMessage = " cap nahi hai ";
                return;
            }
            //checking for a atleast a single lower letter
            bool lower = false;
            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    lower = true;
                    break;
                }
            }
            if (!lower)
            {
                UidCustomValidate.ErrorMessage = " lower nahi hai ";
                return;
            }
            bool digit = false;
            foreach (char ch in str)
            {
                if (ch >= '0' && ch <= '9')
                {
                    digit = true;
                    break;
                }
            }
            if (!digit)
            {
                UidCustomValidate.ErrorMessage = " digit nahi hai ";
                return;
            }
            args.IsValid = true;
        }
    }
}