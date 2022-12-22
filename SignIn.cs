using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;

namespace salonKrasoti
{
    public partial class SignIn : Form
    {
        int roleID;


        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=323-1\SQLEXPRESS;Initial Catalog=salonKrasoti; Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Пользователи WHERE Логин='" + loginInput.Text + "' AND Пароль='" + passwordInput.Text + "'", con);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            sda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {
                sda = new SqlDataAdapter("SELECT IDРоли FROM Пользователи WHERE Логин ='"+loginInput.Text +"' AND Пароль = '"+ passwordInput.Text+"'", con);
                sda.Fill(dt2);
                switch (dt2.Rows[0][0].ToString())
                {
                    case "1":
                        this.Hide();
                        new AdminForm().Show();
                        break;
                    case "2":
                        this.Hide();
                        new EmployeeForm().Show();
                        break;
                    case "3":
                        this.Hide();
                        new ClientForm().Show();
                        break;
                }
            }
            else
                MessageBox.Show("Неправильный пользователь или пароль");

        }
    }
}
