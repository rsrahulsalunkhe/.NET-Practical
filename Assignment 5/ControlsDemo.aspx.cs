using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public partial class ControlsDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessage.Text = "Select your preferences.";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedCountry = ddlCountries.SelectedValue;
            string selectedInterests = GetSelectedItems(cblInterests);
            string selectedGender = rblGender.SelectedValue;

            lblMessage.Text = $"Country: {selectedCountry}<br />Interests: {selectedInterests}<br />Gender: {selectedGender}";
        }

        private string GetSelectedItems(System.Web.UI.WebControls.ListControl list)
        {
            string selectedItems = "";
            foreach (System.Web.UI.WebControls.ListItem item in list.Items)
            {
                if (item.Selected)
                {
                    selectedItems += item.Value + ", ";
                }
            }

            if (!string.IsNullOrEmpty(selectedItems))
            {
                selectedItems = selectedItems.Substring(0, selectedItems.Length - 2);
            }

            return selectedItems;
        }
    }
}