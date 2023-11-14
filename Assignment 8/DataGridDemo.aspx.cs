using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_8
{
    public partial class DataGridDemo : System.Web.UI.Page
    {
        private DataTable dataTable;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dataTable = new DataTable();
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Age", typeof(int));
                dataTable.Columns.Add("City");

                for (int i = 1; i <= 100; i++)
                {
                    dataTable.Rows.Add($"Person{i}", 20 + i, "City" + (i % 5));
                }

                dataGridDemo.DataSource = dataTable.DefaultView;
                dataGridDemo.DataBind();
            }
        }

        protected void dataGridDemo_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dataGridDemo.CurrentPageIndex = e.NewPageIndex;
            dataGridDemo.DataSource = dataTable.DefaultView;
            dataGridDemo.DataBind();
        }

        protected void dataGridDemo_SortCommand(object source, DataGridSortCommandEventArgs e)
        {
            dataTable.DefaultView.Sort = e.SortExpression;
            dataGridDemo.DataSource = dataTable.DefaultView;
            dataGridDemo.DataBind();
        }

        protected void dataGridDemo_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView rowView = (DataRowView)e.Item.DataItem;
                int age = (int)rowView["Age"];

                if (age > 30)
                {
                    e.Item.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }
    }
}