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

namespace InventoryManagement
{
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ioannis Saltidis\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

            private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values(" + CustomerIdTb.Text + ",'" + CustomerNameTb.Text + "','" + CustomerPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                populate();

            }
            catch
            {

            }
        }

        private void CustomersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTb.Text = CustomersGv.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTb.Text = CustomersGv.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhoneTb.Text = CustomersGv.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustomerIdTb.Text == "")
            {
                MessageBox.Show("Enter the Customer ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomerTbl where CustId= '" + CustomerIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName='" + CustomerNameTb.Text + "',CustPhone='" + CustomerPhoneTb.Text + "' where CustId='" + CustomerIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                populate();

            }
            catch
            {

            }
        }
    }
}
