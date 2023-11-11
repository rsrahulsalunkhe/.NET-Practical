using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessage.Text = "Fill out the registration form.";
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Registration successful!";
        }
    }
}