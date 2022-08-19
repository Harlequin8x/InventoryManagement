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
    public partial class ManageProduct : Form
    {
        public ManageProduct()
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
                Con.Close();
            }

            catch
            {

            }
        }

        private void unameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ProductsGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTb.Text = ProductsGv.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTb.Text = ProductsGv.SelectedRows[0].Cells[1].Value.ToString();
            QtyTb.Text = ProductsGv.SelectedRows[0].Cells[2].Value.ToString();
            PriceTb.Text = ProductsGv.SelectedRows[0].Cells[3].Value.ToString();
            DescriptionTb.Text = ProductsGv.SelectedRows[0].Cells[4].Value.ToString();
            CatCombo.SelectedValue = ProductsGv.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void CustomEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProdName='" + ProdNameTb.Text + "', ProdQty=" + QtyTb.Text + ", ProdPrice=" + PriceTb.Text + "', ProdDesc = '" + DescriptionTb.Text + "', ProdCat = " + CatCombo.SelectedValue.ToString() + "'  where ProdId=" + ProdIdTb.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                populate();
            }

            catch
            {
                
            }
        }


        private void ManageProduct_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void CatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                ProductsGv.DataSource = ds.Tables[0];
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
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values(" + ProdIdTb.Text + ",'" + ProdNameTb.Text + "'," + QtyTb.Text + "," + PriceTb.Text + ",'" + DescriptionTb.Text + "' , '" + CatCombo.SelectedValue.ToString() + "' )", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                populate();

            }

            catch
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomDelete_Click(object sender, EventArgs e)
        {
            if (ProdIdTb.Text == "")
            {
                MessageBox.Show("Enter the Category ID");

            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTbl where ProdId= '" + ProdIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();
            }
        }


    }
}
