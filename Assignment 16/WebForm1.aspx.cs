using System;
using System.Data;
using System.Web.UI.WebControls;

namespace DataTableObject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private DataTable dataTable;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize and bind the DataTable to the GridView
                dataTable = CreateDataTable();
                BindGridView();
            }
        }

        private DataTable CreateDataTable()
        {
            // Create a DataTable with columns
            DataTable dt = new DataTable("Employee");
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Salary", typeof(decimal));

            // Add some data to the DataTable
            dt.Rows.Add(1, "John Doe", 50000.50);
            dt.Rows.Add(2, "Jane Smith", 60000.75);
            dt.Rows.Add(3, "Bob Johnson", 75000.25);

            return dt;
        }

        private void BindGridView()
        {
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Set the GridView in edit mode
            GridView1.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // Cancel the edit mode
            GridView1.EditIndex = -1;
            BindGridView();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Update the DataTable with the edited values
            int rowIndex = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[rowIndex].Value);
            string name = (GridView1.Rows[rowIndex].FindControl("txtName") as TextBox).Text;
            decimal salary = Convert.ToDecimal((GridView1.Rows[rowIndex].FindControl("txtSalary") as TextBox).Text);

            // Update the DataTable
            DataRow row = dataTable.Rows.Find(id);
            row["Name"] = name;
            row["Salary"] = salary;

            // Exit the edit mode
            GridView1.EditIndex = -1;
            BindGridView();
        }
    }
}
