using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Display_Data_in_HTML_Table
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tblStudent";
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            StringBuilder htmlTable = new StringBuilder();

            if (!IsPostBack)
            {
                // Start of teh Table tag
                htmlTable.Append("<table border='1' style='width:50%; height:50%;'>");

                using (cmd)
                {
                    // Start of the Table Body

                        // Table Head
                    htmlTable.Append("<tr>" +
                        "<th>ID</th>" +
                        "<th>Name</th>" +
                        "<th>Mobile No</th>" +
                        "<th>Email - ID</th>" +
                        "</tr>");

                        // Table Content Body
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            htmlTable.Append("<tr>");
                            htmlTable.Append("<td>" + reader["id"] + "</td>");
                            htmlTable.Append("<td>" + reader["name"] + "</td>");
                            htmlTable.Append("<td>" + reader["mobile_no"] + "</td>");
                            htmlTable.Append("<td>" + reader["email_id"] + "</td>");
                            htmlTable.Append("</tr>");
                        }
                    }

                    // End of the Table Body
                }

                // End of the Table tag
                htmlTable.Append("</table>");

                PlaceHolder1.Controls.Add(new Literal { Text = htmlTable.ToString() });

                // Closing the reader
                reader.Close();
                reader.Dispose();
            }
        }
    }
}