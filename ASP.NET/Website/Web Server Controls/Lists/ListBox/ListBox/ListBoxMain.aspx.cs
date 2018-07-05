using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBox
{
    public partial class ListBoxMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // Adds an Item typed in the TextBox ito the ListBox
            String add_item = txbAdd.Text;

            // To check whether the Item to be Added already exists within the ListBox
            ListItem item = lsbx1.Items.FindByText(add_item);

            // If Item is found
            if (item != null)
                lblDisplay.Text = "The Item to be Added already Exists within the ListBox.";

            // If the Item does not exist then add it to the ListBox
            else
            {
                lsbx1.Items.Add(add_item);
                lblDisplay.Text = "Item Added to the ListBox";
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            // To Remove a particular Item Selected by the User
            String rem_item = lsbx1.SelectedItem.ToString();

            lsbx1.Items.Remove(rem_item);
            lblDisplay.Text = "Item " + rem_item + " removed from the List";
        }

        protected void btnCount_Click(object sender, EventArgs e)
        {
            // To Count the Number of Items within the ListBox
            lblDisplay.Text = "The Count of Items = " + lsbx1.Items.Count.ToString();
        }

        protected void btnIndex_Click(object sender, EventArgs e)
        {
            // To retrieve the Index of the Selected Item
            lblDisplay.Text = "The Index = " + lsbx1.SelectedIndex.ToString();
        }

        protected void btnSelText_Click(object sender, EventArgs e)
        {
            // To retrieve the Value of the Selected Text from within the ListBox
            lblDisplay.Text = "The Selected Item = " + lsbx1.SelectedItem.Text;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            // To Clear the ListBox
            lsbx1.Items.Clear();
            lblDisplay.Text = "ListBox Cleared";
        }
    }
}