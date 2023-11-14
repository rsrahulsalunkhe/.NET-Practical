using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_7
{
    public partial class RepeaterControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Person> people = new List<Person>
                {
                    new Person { Name = "Rahul Salunkhe", Age = 23, City = "Amalner" },
                    new Person { Name = "Dhaneshwar Bhakat", Age = 25, City = "TATA Nagar" },
                    new Person { Name = "Anurag Kable", Age = 30, City = "Mumbai" }
                };

                repeaterDemo.DataSource = people;
                repeaterDemo.DataBind();
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }
    }
}