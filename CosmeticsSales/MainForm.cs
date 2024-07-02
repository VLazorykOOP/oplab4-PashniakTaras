using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CosmeticsSales
{
    public partial class MainForm : Form
    {
        MySqlConnection connection;

        public MainForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=CosmeticsDB;user=root;password=Inux0706";
            connection = new MySqlConnection(connectionString);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Products";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            addForm.ShowDialog();
            LoadData(); // Refresh data after adding a product
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditProductForm editForm = new EditProductForm();
            editForm.ShowDialog();
            LoadData(); // Refresh data after editing a product
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            SearchProductForm searchForm = new SearchProductForm();
            searchForm.ShowDialog();
            LoadData(); // Refresh data after searching a product
        }

        private void btnOrderProduct_Click(object sender, EventArgs e)
        {
            OrderProductForm orderForm = new OrderProductForm();
            orderForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
