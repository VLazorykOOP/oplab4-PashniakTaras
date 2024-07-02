using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CosmeticsSales
{
    public partial class OrderProductForm : Form
    {
        MySqlConnection connection;

        public OrderProductForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=CosmeticsDB;user=root;password=Inux0706";
            connection = new MySqlConnection(connectionString);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Orders (ProductId, Quantity, OrderDate) VALUES (@ProductId, @Quantity, @OrderDate)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(txtProductId.Text));
                cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order placed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
