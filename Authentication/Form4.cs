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
    public partial class bulkData : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();

        public bulkData()
        {
            InitializeComponent();
        }

        private void bulkData_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Student Name", typeof(string));
            dt.Columns.Add("Department ID", typeof(int));
            dt.Columns.Add("ADDress", typeof(string));

            dataGridView1.DataSource = dt;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = @"Data Source=FaizanPC\MSSQLSERVER01;Initial Catalog=Departments;Integrated Security=True";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            //specifying the stored Procedured
            cmd.CommandText = "BULK_Insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@records", dt);
            cmd.Connection = con;

            
                //ExecuteNonQuery method is used to execute the query like insert update delete and ite returns the number of row changed

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Students inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to insert Students.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
