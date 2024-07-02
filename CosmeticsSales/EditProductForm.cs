using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Management;

namespace CosmeticsSales
{
    public partial class EditProductForm : Form
    {
        MySqlConnection connection;

        public EditProductForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=CosmeticsDB;user=root;password=Inux0706";
            connection = new MySqlConnection(connectionString);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Products SET Type=@Type, Brand=@Brand, Manufacturer=@Manufacturer, ExpiryDate=@ExpiryDate, Price=@Price WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Type", txtType.Text);
                cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product updated successfully");
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
