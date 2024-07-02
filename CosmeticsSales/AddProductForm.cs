using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Management;

namespace CosmeticsSales
{
    public partial class AddProductForm : Form
    {
        MySqlConnection connection;

        public AddProductForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=CosmeticsDB;user=root;password=Inux0706";
            connection = new MySqlConnection(connectionString);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Products (Type, Brand, Manufacturer, ExpiryDate, Price) VALUES (@Type, @Brand, @Manufacturer, @ExpiryDate, @Price)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Type", txtType.Text);
                cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
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
