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

namespace Data_in_HTML_Table_With_Options
{
    public partial class Default : System.Web.UI.Page
    {
        // Initializing the SQL Connection
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);

        DataTable dt = new DataTable();
        StringBuilder table = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        protected void btnSpecificDate_Click(object sender, EventArgs e)
        {
            // 1. User can search Customer list of Specific Date
            DateTime date = DateTime.ParseExact(txbSpecificDate.Text, "dd/MM/yyyy", null);
            string cmd = "SELECT * FROM cust_order WHERE order_date = '" + date.ToString("yyyy-MM-dd") + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            adapter.Fill(dt);

            // Start of the HTML Table
            table.Append("<table style='width:70%; border:1px solid black; border-spacing:1em;'>");
            table.Append("<tr>");
            table.Append("<th>PRODUCT NUMBER</th>");
            table.Append("<th>CUSTOMER NAME</th>");
            table.Append("<th>ORDER DATE</th>");
            table.Append("<th>AMOUNT</th>");
            table.Append("<th>CONTACT NUMBER</th>");
            table.Append("</tr>");

            // Fetching all thw Records
            foreach (DataRow row in this.dt.Rows)
            {
                table.Append("<tr>");
                table.Append("<td>" + row[0].ToString() + "</td>");
                table.Append("<td>" + row[1].ToString() + "</td>");
                table.Append("<td>" + row[2].ToString() + "</td>");
                table.Append("<td>" + row[3].ToString() + "</td>");
                table.Append("<td>" + row[4].ToString() + "</td>");
                table.Append("</tr>");
            }
            // End of the HTML Table
            table.Append("</table>");

            // Add everything to the Placeholder
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
        }

        protected void btnDateRange_Click(object sender, EventArgs e)
        {
            // 2. User can search Customer list between two Dates
            DateTime startDate = DateTime.ParseExact(txbStartDate.Text, "dd/MM/yyyy", null);
            DateTime endDate = DateTime.ParseExact(txbEndDate.Text, "dd/MM/yyyy", null);
            string cmd = "SELECT * FROM cust_order WHERE order_date >= '"
                + startDate.ToString("yyyy-MM-dd") + "' and order_date <= '"
                + endDate.ToString("yyyy-MM-dd") + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            adapter.Fill(dt);

            // Start of the HTML Table
            table.Append("<table style='width:70%; border:1px solid black; border-spacing:1em;'>");
            table.Append("<tr>");
            table.Append("<th>PRODUCT NUMBER</th>");
            table.Append("<th>CUSTOMER NAME</th>");
            table.Append("<th>ORDER DATE</th>");
            table.Append("<th>AMOUNT</th>");
            table.Append("<th>CONTACT NUMBER</th>");
            table.Append("</tr>");

            // Fetching all thw Records
            foreach (DataRow row in this.dt.Rows)
            {
                table.Append("<tr>");
                table.Append("<td>" + row[0].ToString() + "</td>");
                table.Append("<td>" + row[1].ToString() + "</td>");
                table.Append("<td>" + row[2].ToString() + "</td>");
                table.Append("<td>" + row[3].ToString() + "</td>");
                table.Append("<td>" + row[4].ToString() + "</td>");
                table.Append("</tr>");
            }
            // End of the HTML Table
            table.Append("</table>");

            // Add everything to the Placeholder
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
        }

        protected void btnProdNo_Click(object sender, EventArgs e)
        {
            // 3. User can search the count of Orders on specific date by giving the Product no
            string cmd = "SELECT * FROM cust_order WHERE product_no = " + txbProductNo.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            adapter.Fill(dt);

            // Start of the HTML Table
            table.Append("<table style='width:70%; border:1px solid black; border-spacing:1em;'>");
            table.Append("<tr>");
            table.Append("<th>PRODUCT NUMBER</th>");
            table.Append("<th>CUSTOMER NAME</th>");
            table.Append("<th>ORDER DATE</th>");
            table.Append("<th>AMOUNT</th>");
            table.Append("<th>CONTACT NUMBER</th>");
            table.Append("</tr>");

            // Fetching all thw Records
            foreach (DataRow row in this.dt.Rows)
            {
                table.Append("<tr>");
                table.Append("<td>" + row[0].ToString() + "</td>");
                table.Append("<td>" + row[1].ToString() + "</td>");
                table.Append("<td>" + row[2].ToString() + "</td>");
                table.Append("<td>" + row[3].ToString() + "</td>");
                table.Append("<td>" + row[4].ToString() + "</td>");
                table.Append("</tr>");
            }
            // End of the HTML Table
            table.Append("</table>");

            // Add everything to the Placeholder
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
        }
    }
}