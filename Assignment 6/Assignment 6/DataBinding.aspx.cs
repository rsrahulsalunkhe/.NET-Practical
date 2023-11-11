using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_6
{
    public partial class DataBinding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Hashtable hashtableData = new Hashtable();
                hashtableData.Add("Name", "Rahul Salunkhe");
                hashtableData.Add("Age", 23);
                hashtableData.Add("City", "Amalner");

                lblHashtable.Text = "DataBinding using Hashtable";
                gvHashtable.DataSource = new ArrayList { hashtableData };
                gvHashtable.DataBind();

                ArrayList arrayListData = new ArrayList();
                arrayListData.Add(new { Name = "Rahul Salunkhe", Age = 23, City = "Jalgaon" });
                arrayListData.Add(new { Name = "Bob Smith", Age = 35, City = "Los Angeles" });

                lblArrayList.Text = "DataBinding using ArrayList";
                gvArrayList.DataSource = arrayListData;
                gvArrayList.DataBind();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Age", typeof(int));
                dataTable.Columns.Add("City");

                dataTable.Rows.Add("Alice Johnson", 28, "Chicago");
                dataTable.Rows.Add("Michael Brown", 40, "Dallas");

                lblDataTable.Text = "DataBinding using DataTable";
                gvDataTable.DataSource = dataTable;
                gvDataTable.DataBind();
            }
        }
    }
}