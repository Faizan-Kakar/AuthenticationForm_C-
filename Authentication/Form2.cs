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

namespace Authentication
{
    public partial class logIn : Form
    {

        SqlConnection con = new SqlConnection();
        public logIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;

            con.ConnectionString = @"Data Source=FaizanPC\MSSQLSERVER01;Initial Catalog=Authentication;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select PasswordHash from Users where Email = @Username";
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Connection = con;

            try
            {
               // ExecuteScalar() is used to execute the query and return the data
                string PasswordHash = (string)cmd.ExecuteScalar();
                if(PasswordHash == null)
                {
                    MessageBox.Show("User not found" , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(PasswordHash != Password)
                {
                    MessageBox.Show("Password is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Error" );
            }
            

            con.Close();
        }
    }
}
