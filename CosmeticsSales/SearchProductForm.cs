using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Management;

namespace CosmeticsSales
{
    public partial class SearchProductForm : Form
    {
        MySqlConnection connection;

        public SearchProductForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=CosmeticsDB;user=root;password=Inux0706";
            connection = new MySqlConnection(connectionString);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Products WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtType.Text = reader["Type"].ToString();
                    txtBrand.Text = reader["Brand"].ToString();
                    txtManufacturer.Text = reader["Manufacturer"].ToString();
                    dtpExpiryDate.Value = Convert.ToDateTime(reader["ExpiryDate"]);
                    txtPrice.Text = reader["Price"].ToString();
                }
                else
                {
                    MessageBox.Show("Product not found");
                }
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
