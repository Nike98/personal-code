using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace DataBase_Example_1
{
     
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;


        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
            conn.Open();

            cmd = new SqlCommand("Insert into tblStudent (FirstName,LastName,Gender,Mobile,Email) values (@FirstName,@LastName,@Gender,@Mobile,@Email)", conn);
            cmd.Parameters.AddWithValue("@FirstName",txbFName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", txbLName.Text.Trim());
            cmd.Parameters.AddWithValue("@Gender",ddlGender.SelectedItem.Text.Trim());
            cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            int x=cmd.ExecuteNonQuery();
            if(x>0)
            {
                lblStatus.Text =txbFName.Text+ " "+ txbLName.Text+ " Inserted Succesfully";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblStatus.Text = txbFName.Text + " " + txbLName.Text + "NOT Inserted!!!!!!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            conn.Close();
        }
    }
}