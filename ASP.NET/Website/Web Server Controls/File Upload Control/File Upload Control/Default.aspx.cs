using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace File_Upload_Control
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            FileUploadControl1.SaveAs(Server.MapPath("~/Uploads/") + FileUploadControl1.FileName);
            lblStatus.Text = "Successful";
            lblStatus.ForeColor = System.Drawing.Color.Green;
           
            using (StreamReader st = new StreamReader(Server.MapPath("~/Uploads/") + FileUploadControl1.FileName))
            {
                string str = st.ReadToEnd();
                txbContent.Text = str;
            }
        }
    }
}