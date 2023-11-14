using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_9
{
    public partial class DataGridandDataListEdit : System.Web.UI.Page
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

                for (int i = 1; i <= 5; i++)
                {
                    dataTable.Rows.Add($"Person{i}", 20 + i, "City" + (i % 3));
                }

                dataGridDemo.DataSource = dataTable.DefaultView;
                dataGridDemo.DataBind();

                dataListDemo.DataSource = dataTable.DefaultView;
                dataListDemo.DataBind();
            }
        }

        protected void dataGridDemo_SortCommand(object source, DataGridSortCommandEventArgs e)
        {
            dataTable.DefaultView.Sort = e.SortExpression;
            dataGridDemo.DataSource = dataTable.DefaultView;
            dataGridDemo.DataBind();
        }

        protected void dataGridDemo_EditCommand(object source, DataGridCommandEventArgs e)
        {
            dataGridDemo.EditItemIndex = e.Item.ItemIndex;
            dataGridDemo.DataSource = dataTable.DefaultView;
            dataGridDemo.DataBind();
        }

        protected void dataGridDemo_CancelCommand(object source, DataGridCommandEventArgs e)
        {
            dataGridDemo.EditItemIndex = -1;
            dataGridDemo.DataSource = dataTable.DefaultView;
            dataGridDemo.DataBind();
        }

        protected void dataGridDemo_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            TextBox txtName = (TextBox)e.Item.FindControl("txtName");
            TextBox txtAge = (TextBox)e.Item.FindControl("txtAge");
            TextBox txtCity = (TextBox)e.Item.FindControl("txtCity");

            int rowIndex = e.Item.ItemIndex;
            DataRowView rowView = (DataRowView)dataTable.DefaultView[rowIndex];

            rowView["Name"] = txtName.Text;
            rowView["Age"] = int.Parse(txtAge.Text);
            rowView["City"] = txtCity.Text;

            dataGridDemo.EditItemIndex = -1;
            dataGridDemo.DataSource = dataTable.DefaultView;
            dataGridDemo.DataBind();
        }

        protected void dataGridDemo_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                DataRowView rowView = (DataRowView)e.Item.DataItem;
                int age = (int)rowView["Age"];

                if (age > 30)
                {
                    e.Item.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        protected void dataListDemo_EditCommand(object source, DataListCommandEventArgs e)
        {
            dataListDemo.EditItemIndex = e.Item.ItemIndex;
            dataListDemo.DataSource = dataTable.DefaultView;
            dataListDemo.DataBind();
        }

        protected void dataListDemo_CancelCommand(object source, DataListCommandEventArgs e)
        {
            dataListDemo.EditItemIndex = -1;
            dataListDemo.DataSource = dataTable.DefaultView;
            dataListDemo.DataBind();
        }

        protected void dataListDemo_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            TextBox txtName = (TextBox)e.Item.FindControl("txtName");
            TextBox txtAge = (TextBox)e.Item.FindControl("txtAge");
            TextBox txtCity = (TextBox)e.Item.FindControl("txtCity");

            int itemIndex = e.Item.ItemIndex;
            DataRowView rowView = (DataRowView)dataTable.DefaultView[itemIndex];

            rowView["Name"] = txtName.Text;
            rowView["Age"] = int.Parse(txtAge.Text);
            rowView["City"] = txtCity.Text;

            dataListDemo.EditItemIndex = -1;
            dataListDemo.DataSource = dataTable.DefaultView;
            dataListDemo.DataBind();
        }

        protected void dataListDemo_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
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