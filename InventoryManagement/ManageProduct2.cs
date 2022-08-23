using Guna.UI2.WinForms.Suite;
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

namespace InventoryManagement
{
    public partial class ManageProduct2 : Form
    {
        public ManageProduct2()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ioannis Saltidis\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void fillcategory()
        {
            string query = "select * from CategoriesTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;

            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }

            catch
            {

            }
        }

        


        void filterbycategory()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl where ProdCat='" + SearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values(" + ProdIdTb.Text + ",'" + ProdNameTb.Text + "'," + ProdQtyTb.Text + "," + ProdPriceTb.Text + ",'" + ProdDescTb.Text + "' , '" + CatCombo.SelectedValue.ToString() + "' )", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                populate();

            }

            catch
            {

            }
        }

        private void CustomersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTb.Text = ProductGv.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTb.Text = ProductGv.SelectedRows[0].Cells[1].Value.ToString();
            ProdQtyTb.Text = ProductGv.SelectedRows[0].Cells[2].Value.ToString();
            ProdPriceTb.Text = ProductGv.SelectedRows[0].Cells[3].Value.ToString();
            ProdDescTb.Text = ProductGv.SelectedRows[0].Cells[4].Value.ToString();
            CatCombo.SelectedValue = ProductGv.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void ManageProduct2_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomDelete_Click(object sender, EventArgs e)
        {
            if (ProdIdTb.Text == "")
            {
                MessageBox.Show("Enter the Product ID");

            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTbl where ProdId=" + ProdIdTb.Text + " ;";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();
            }

        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void CatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomEdit2_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();                
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProdName='" + ProdNameTb.Text + "' ,ProdQty=" + ProdQtyTb.Text + " , ProdPrice=" + ProdPriceTb.Text + " ,ProdDesc='" + ProdDescTb.Text + "' ,ProdCat='" + CatCombo.SelectedValue.ToString() + "' where ProdId=" + ProdIdTb.Text + "", Con);
                // Console.WriteLine();   put into writeline: "update ProductTbl set ProdName='"....
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                populate();
                
            }
            catch
            {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterbycategory();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
