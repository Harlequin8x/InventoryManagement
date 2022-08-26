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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ioannis Saltidis\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            /*DataColumn column;
            DataRow row;
            // DataView view;

            column = new DataColumn();

            for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();                
                table.Rows.Add(row);
            }*/

            if (QtyTb.Text == "")
                MessageBox.Show("Enter the Quantity of Products");
            else if (flag == 0)
                MessageBox.Show("Select the Product");
            else if (Convert.ToInt32(QtyTb.Text) > stock)
                MessageBox.Show("Not enough Stock available");
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;
                table.Columns.Add("Num", typeof(int));
                table.Columns.Add("Product", typeof(string));
                table.Columns.Add("Qty", typeof(int));
                table.Columns.Add("Uprice", typeof(int));
                table.Columns.Add("TotPrice", typeof(int));
                table.Rows.Add(num, product, qty, uprice, totprice);
                OrderGv.DataSource = table;
                flag = 0;
            }
            sum = sum + totprice;
            TotAmount.Text = "Rs" + sum.ToString();
            
        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTbl";     // CustomerTbl before
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        void populateproducts()
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

        void populateorders()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrderGv.DataSource = ds.Tables[0];
                Con.Close();
                
            }
            catch
            {

            }
        }

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
                //CatCombo.ValueMember = "CatName";
                //CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }

            catch
            {

            }
        }

        void updateproduct()
        {
            Con.Open();
            int id = Convert.ToInt32(ProductGv.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            string query = "update ProductTbl set ProdQty = " + newQty + " where ProdId=" + id + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            populateproducts();
        }


        int num = 0;
        int uprice, totprice, qty;
        string product;

        private void ManageOrders_Load(object sender, EventArgs e)
        {

            populate();
            populateproducts();
            fillcategory();
            //populateorders();            
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(int));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UPrice", typeof(int));
            table.Columns.Add("TotPrice", typeof(int));

            OrderGv.DataSource = table;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int flag = 0;
        int stock;
        private void ProductGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductGv.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(QtyTb.Text);
            stock = Convert.ToInt32(ProductGv.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductGv.SelectedRows[0].Cells[3].Value.ToString());
            //totprice = qty * uprice;
            flag = 1;
        }

        private void CustomersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustId.Text = CustomersGv.SelectedRows[0].Cells[0].Value.ToString();
        }

        
        private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            
        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
