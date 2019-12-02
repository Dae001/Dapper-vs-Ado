using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using Dapper_vs_Ado.Models;
using Dapper;

namespace Dapper_vs_Ado
{
    public partial class frmCustomer : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["NorthwindDB"].ConnectionString;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private IEnumerable<Customer> GetAllCustomersAdo()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = @"SELECT * FROM Customers";
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Customer> allCustomers = new List<Customer>();
                        while (reader.Read())
                        {
                            Customer customer = new Customer
                            {
                                CustomerId = reader["CustomerID"].ToString(),
                                CompanyName = reader["CompanyName"].ToString(),
                                ContactName = reader["ContactName"].ToString(),
                                ContactTitle = reader["ContactTitle"].ToString(),
                                Address = reader["Address"].ToString(),
                                City = reader["City"].ToString()
                            };
                            allCustomers.Add(customer);
                        }
                        return allCustomers;
                    }
                }
            }
        }

        private IEnumerable<Customer> GetAllCustomersDapper()
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                IEnumerable<Customer> allCustomers = connection.Query<Customer>(@"SELECT * FROM Customers");
                return allCustomers;
            }
        }

        private void btnAdo_Click(object sender, System.EventArgs e)
        {
            dgvCustomer.DataSource = GetAllCustomersAdo();
        }

        private void btnDapper_Click(object sender, System.EventArgs e)
        {
            dgvCustomer.DataSource = GetAllCustomersDapper();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form test = new Form1();
            test.Show();

        }
    }
}
