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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ioannis Saltidis\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30"); 

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGv.DataSource = ds.Tables[0];
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

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + unameTb.Text + "','" + FnameTb.Text + "','" + PasswordTb.Text + "','" + PhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                populate();

            }
            catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageUsers_Load_1(object sender, EventArgs e)
        {
            populate();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = UsersGv.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = UsersGv.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = UsersGv.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = UsersGv.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(PhoneTb.Text == "")
            {
                MessageBox.Show("Enter the Users phone number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where UPhone= '" + PhoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname= '" + unameTb.Text + "',Ufullname='" + FnameTb.Text + "',Upassword= '" + PasswordTb.Text + "' where UPhone='" +PhoneTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                populate();

            }
            catch
            {

            }
        }
    }
}
