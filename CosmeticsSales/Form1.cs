using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Management;

namespace CosmeticsSales
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;

        public Form1()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM Products WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully");
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
