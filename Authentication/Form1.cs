using Mysqlx;
using Org.BouncyCastle.Crypto.Fpe;
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
using System.Xml.Linq;

namespace Authentication
{
    public partial class create : Form
    {
        

        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();


        public create()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            string FirstName = firstName.Text;
            string LastName = lastName.Text;
            string Email = email.Text;
            string Password = password.Text;
            string ConfirmPassword = confirmPassword.Text;

            //To Perform Validation

            validation(FirstName, LastName, Email, Password, ConfirmPassword);
            /*
            logIn f2 = new logIn();
            f2.Show();
            this.Hide();
            */
        }

        

        private void create_Load(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        //local Methods
        private void validation(string FirstName , string LastName , string Email , string Password, string ConfirmPassword)
        {
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) ||
              string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password) ||
              string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Name = FirstName + " " + LastName;
           Registration(Name  , Email, Password);
        }
        private void Registration(string Username , string Email , string Password)
        {

            con.ConnectionString = @"Data Source=FaizanPC\MSSQLSERVER01;Initial Catalog=Authentication;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Users  (Username , Email , PasswordHash)  values (@Username , @Email , @Password)";
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Connection = con;
            try
            {
                //ExecuteNonQuery method is used to execute the query like insert update delete and ite returns the number of row changed

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to insert user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logIn logIn = new logIn();
            logIn.Show();
            this.Hide();
        }
    }
}
