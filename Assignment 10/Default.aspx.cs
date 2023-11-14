using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace Assignment_10
{
    public partial class _Default : System.Web.UI.Page
    {
        private DataTable productsTable;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize sample products
                productsTable = new DataTable();
                productsTable.Columns.Add("ProductID", typeof(int));
                productsTable.Columns.Add("ProductName");
                productsTable.Columns.Add("Price", typeof(decimal));

                productsTable.Rows.Add(1, "Product A", 10.99);
                productsTable.Rows.Add(2, "Product B", 19.99);
                productsTable.Rows.Add(3, "Product C", 15.49);
                productsTable.Rows.Add(4, "Product D", 8.99);

                // Bind products to the DataList
                dlProducts.DataSource = productsTable;
                dlProducts.DataBind();
            }

            // Bind the shopping cart items to the Repeater
            BindCartItems();
        }

        protected void dlProducts_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                // Add the selected product to the shopping cart
                int productID = Convert.ToInt32(e.CommandArgument);
                AddToCart(productID);
            }
        }

        protected void rptCart_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "RemoveFromCart")
            {
                // Remove the selected product from the shopping cart
                int productID = Convert.ToInt32(e.CommandArgument);
                RemoveFromCart(productID);
            }
        }

        private void AddToCart(int productID)
        {
            // Check if the session variable exists
            if (Session["ShoppingCart"] == null)
            {
                // If not, create a new List to store cart items
                Session["ShoppingCart"] = new List<CartItem>();
            }

            // Get the shopping cart from the session
            List<CartItem> cartItems = (List<CartItem>)Session["ShoppingCart"];

            // Check if the product is already in the cart
            CartItem existingItem = cartItems.Find(item => item.ProductID == productID);

            if (existingItem != null)
            {
                // If the product is already in the cart, increase the quantity
                existingItem.Quantity++;
            }
            else
            {
                // If the product is not in the cart, add it
                DataRow productRow = productsTable.Select($"ProductID = {productID}")[0];
                string productName = productRow["ProductName"].ToString();
                decimal price = Convert.ToDecimal(productRow["Price"]);

                CartItem newItem = new CartItem
                {
                    ProductID = productID,
                    ProductName = productName,
                    Price = price,
                    Quantity = 1
                };

                cartItems.Add(newItem);
            }

            // Update the session variable with the modified cart
            Session["ShoppingCart"] = cartItems;

            // Bind the updated cart items to the Repeater
            BindCartItems();
        }

        private void RemoveFromCart(int productID)
        {
            // Get the shopping cart from the session
            List<CartItem> cartItems = (List<CartItem>)Session["ShoppingCart"];

            // Find the product in the cart
            CartItem itemToRemove = cartItems.Find(item => item.ProductID == productID);

            if (itemToRemove != null)
            {
                // Remove the product from the cart
                cartItems.Remove(itemToRemove);

                // Update the session variable with the modified cart
                Session["ShoppingCart"] = cartItems;

                // Bind the updated cart items to the Repeater
                BindCartItems();
            }
        }

        private void BindCartItems()
        {
            // Get the shopping cart from the session
            List<CartItem> cartItems = (List<CartItem>)Session["ShoppingCart"];

            // Bind the cart items to the Repeater
            rptCart.DataSource = cartItems;
            rptCart.DataBind();
        }

        public class CartItem
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public decimal Total
            {
                get { return Price * Quantity; }
            }
        }
    }
}
