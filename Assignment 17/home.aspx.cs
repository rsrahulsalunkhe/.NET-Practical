using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webservicedemo
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService1 w1 = new WebService1();
            
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox2.Text);

            Label1.Text = w1.add(a, b).ToString();
        }
    }
}