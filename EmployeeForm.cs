using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salonKrasoti
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonKrasotiDataSet.Услуги". При необходимости она может быть перемещена или удалена.



        }

        private void servicesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=323-1\SQLEXPRESS;Initial Catalog=salonKrasoti; Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Услуги", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            servicesGridView.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=323-1\SQLEXPRESS;Initial Catalog=salonKrasoti; Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Клиент", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            servicesGridView.DataSource = dt;

        }
    }
}
