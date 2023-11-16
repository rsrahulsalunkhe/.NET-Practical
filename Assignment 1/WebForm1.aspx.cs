using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            // Code to execute during PreInit
            //Response.Write("Code to execute during PreInit <br/>");
            myLabel.Text += "PreInit<br/>";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            // Code to execute during Init
            //Response.Write("Code to execute during Init <br/>");
            myLabel.Text += "Init<br/>";
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            // Code to execute during InitComplete
            //Response.Write("Code to execute during InitComplete <br/>");
            myLabel.Text += "InitComplete<br/>";
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            // Code to execute during PreLoad
            myLabel.Text += "PreLoad<br/>";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Code to execute during Load
            myLabel.Text += "Load<br/>";

            // Example: Set a label's text during Page Load
            myLabel.Text += "Setting label text during Load<br/>";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Code for Button Click event
            myLabel.Text += "Button Clicked!<br/>";
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            // Code to execute during LoadComplete
            myLabel.Text += "LoadComplete<br/>";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            // Code to execute during PreRender
            myLabel.Text += "PreRender<br/>";
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            // Code to execute during PreRenderComplete
            myLabel.Text += "PreRenderComplete<br/>";
        }

        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            // Code to execute during SaveStateComplete
            myLabel.Text += "SaveStateComplete<br/>";
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            // Code to execute during Render
            myLabel.Text += "Render<br/>";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // Code to execute during Unload
            // Note: Response.Write is used here because the Page is being unloaded, and controls may not be accessible.
            //Response.Write("Unload<br/>");
        }
    }
}
