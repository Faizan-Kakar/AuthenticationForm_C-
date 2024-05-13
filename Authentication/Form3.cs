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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Authentication
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void search_Click(object sender, EventArgs e)
        {
            String id = productId.Text;

            con.ConnectionString = @"Data Source=FaizanPC\MSSQLSERVER01;Initial Catalog=Departments;Integrated Security=True";
            con.Open();


            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select ProductName , Category , Price from Products where ProductID =  @n AND Is_Deleted = 0";

            
            cmd.Parameters.AddWithValue("@n" , id);
            cmd.Connection = con;

            dt.Rows.Clear();

                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = cmd;
                ad.Fill(dt);

                dgv.DataSource = dt;
           
            
          

            con.Close();

        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
