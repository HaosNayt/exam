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
    public partial class ClientForm : Form
    {

        public ClientForm()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=323-1\SQLEXPRESS;Initial Catalog=salonKrasoti; Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSER INTO Предстоящие записи  values ("+dateTimePicker1.Value+"," +comboBox1.Text+",)", con);



        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=323-1\SQLEXPRESS;Initial Catalog=salonKrasoti; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Услуги", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
    }
}
