namespace InventoryManagement
{
    partial class ManageProduct2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ManageUsers_Load = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomHome = new System.Windows.Forms.Button();
            this.CustomDelete = new System.Windows.Forms.Button();
            this.CustomEdit2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProdQtyTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdPriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdDescTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ManageUsers_Load);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 100);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1089, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ManageUsers_Load
            // 
            this.ManageUsers_Load.AutoSize = true;
            this.ManageUsers_Load.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsers_Load.ForeColor = System.Drawing.Color.White;
            this.ManageUsers_Load.Location = new System.Drawing.Point(447, 56);
            this.ManageUsers_Load.Name = "ManageUsers_Load";
            this.ManageUsers_Load.Size = new System.Drawing.Size(192, 24);
            this.ManageUsers_Load.TabIndex = 1;
            this.ManageUsers_Load.Text = "Manage Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 614);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 19);
            this.panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(636, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "PRODUCT LIST";
            // 
            // ProductGv
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.ProductGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.ProductGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGv.BackgroundColor = System.Drawing.Color.White;
            this.ProductGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.ProductGv.ColumnHeadersHeight = 20;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGv.DefaultCellStyle = dataGridViewCellStyle18;
            this.ProductGv.EnableHeadersVisualStyles = false;
            this.ProductGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGv.Location = new System.Drawing.Point(358, 190);
            this.ProductGv.Name = "ProductGv";
            this.ProductGv.RowHeadersVisible = false;
            this.ProductGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGv.Size = new System.Drawing.Size(713, 386);
            this.ProductGv.TabIndex = 22;
            this.ProductGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.ProductGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductGv.ThemeStyle.HeaderStyle.Height = 20;
            this.ProductGv.ThemeStyle.ReadOnly = false;
            this.ProductGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductGv.ThemeStyle.RowsStyle.Height = 22;
            this.ProductGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGv_CellContentClick);
            // 
            // CustomHome
            // 
            this.CustomHome.BackColor = System.Drawing.Color.Crimson;
            this.CustomHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomHome.FlatAppearance.BorderSize = 0;
            this.CustomHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomHome.ForeColor = System.Drawing.Color.White;
            this.CustomHome.Location = new System.Drawing.Point(102, 522);
            this.CustomHome.Name = "CustomHome";
            this.CustomHome.Size = new System.Drawing.Size(75, 33);
            this.CustomHome.TabIndex = 27;
            this.CustomHome.Text = "Home";
            this.CustomHome.UseVisualStyleBackColor = false;
            // 
            // CustomDelete
            // 
            this.CustomDelete.BackColor = System.Drawing.Color.Crimson;
            this.CustomDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomDelete.FlatAppearance.BorderSize = 0;
            this.CustomDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomDelete.ForeColor = System.Drawing.Color.White;
            this.CustomDelete.Location = new System.Drawing.Point(183, 470);
            this.CustomDelete.Name = "CustomDelete";
            this.CustomDelete.Size = new System.Drawing.Size(75, 33);
            this.CustomDelete.TabIndex = 26;
            this.CustomDelete.Text = "Delete";
            this.CustomDelete.UseVisualStyleBackColor = false;
            this.CustomDelete.Click += new System.EventHandler(this.CustomDelete_Click);
            // 
            // CustomEdit2
            // 
            this.CustomEdit2.BackColor = System.Drawing.Color.Crimson;
            this.CustomEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomEdit2.FlatAppearance.BorderSize = 0;
            this.CustomEdit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomEdit2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomEdit2.ForeColor = System.Drawing.Color.White;
            this.CustomEdit2.Location = new System.Drawing.Point(102, 470);
            this.CustomEdit2.Name = "CustomEdit2";
            this.CustomEdit2.Size = new System.Drawing.Size(75, 33);
            this.CustomEdit2.TabIndex = 25;
            this.CustomEdit2.Text = "Edit";
            this.CustomEdit2.UseVisualStyleBackColor = false;
            this.CustomEdit2.Click += new System.EventHandler(this.CustomEdit2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProdQtyTb
            // 
            this.ProdQtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdQtyTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQtyTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdQtyTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProdQtyTb.HintText = "";
            this.ProdQtyTb.isPassword = false;
            this.ProdQtyTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.ProdQtyTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.ProdQtyTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.ProdQtyTb.LineThickness = 4;
            this.ProdQtyTb.Location = new System.Drawing.Point(28, 236);
            this.ProdQtyTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdQtyTb.Name = "ProdQtyTb";
            this.ProdQtyTb.Size = new System.Drawing.Size(222, 42);
            this.ProdQtyTb.TabIndex = 30;
            this.ProdQtyTb.Text = "ProductQty";
            this.ProdQtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProdNameTb.HintText = "";
            this.ProdNameTb.isPassword = false;
            this.ProdNameTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.ProdNameTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.ProdNameTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.ProdNameTb.LineThickness = 4;
            this.ProdNameTb.Location = new System.Drawing.Point(27, 184);
            this.ProdNameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(222, 42);
            this.ProdNameTb.TabIndex = 29;
            this.ProdNameTb.Text = "ProductName";
            this.ProdNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProdIdTb
            // 
            this.ProdIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIdTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProdIdTb.HintText = "";
            this.ProdIdTb.isPassword = false;
            this.ProdIdTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.ProdIdTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.ProdIdTb.LineMouseHoverColor = System.Drawing.Color.DarkViolet;
            this.ProdIdTb.LineThickness = 4;
            this.ProdIdTb.Location = new System.Drawing.Point(27, 132);
            this.ProdIdTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdIdTb.Name = "ProdIdTb";
            this.ProdIdTb.Size = new System.Drawing.Size(222, 42);
            this.ProdIdTb.TabIndex = 28;
            this.ProdIdTb.Text = "ProductId";
            this.ProdIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProdPriceTb
            // 
            this.ProdPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdPriceTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPriceTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdPriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProdPriceTb.HintText = "";
            this.ProdPriceTb.isPassword = false;
            this.ProdPriceTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.ProdPriceTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.ProdPriceTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.ProdPriceTb.LineThickness = 4;
            this.ProdPriceTb.Location = new System.Drawing.Point(27, 288);
            this.ProdPriceTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdPriceTb.Name = "ProdPriceTb";
            this.ProdPriceTb.Size = new System.Drawing.Size(222, 42);
            this.ProdPriceTb.TabIndex = 31;
            this.ProdPriceTb.Text = "ProductPrice";
            this.ProdPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProdDescTb
            // 
            this.ProdDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdDescTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDescTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdDescTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProdDescTb.HintText = "";
            this.ProdDescTb.isPassword = false;
            this.ProdDescTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.ProdDescTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.ProdDescTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.ProdDescTb.LineThickness = 4;
            this.ProdDescTb.Location = new System.Drawing.Point(28, 340);
            this.ProdDescTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdDescTb.Name = "ProdDescTb";
            this.ProdDescTb.Size = new System.Drawing.Size(222, 42);
            this.ProdDescTb.TabIndex = 32;
            this.ProdDescTb.Text = "Description";
            this.ProdDescTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatCombo
            // 
            this.CatCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CatCombo.ForeColor = System.Drawing.Color.Crimson;
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(28, 399);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(222, 29);
            this.CatCombo.TabIndex = 33;
            this.CatCombo.Text = "Product Category";
            this.CatCombo.SelectedIndexChanged += new System.EventHandler(this.CatCombo_SelectedIndexChanged);
            // 
            // SearchCombo
            // 
            this.SearchCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.SearchCombo.ForeColor = System.Drawing.Color.Crimson;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(641, 142);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(222, 29);
            this.SearchCombo.TabIndex = 34;
            this.SearchCombo.Text = "Select Category";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(862, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 33);
            this.button2.TabIndex = 35;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(947, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 33);
            this.button3.TabIndex = 36;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManageProduct2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 633);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.ProdDescTb);
            this.Controls.Add(this.ProdPriceTb);
            this.Controls.Add(this.ProdQtyTb);
            this.Controls.Add(this.ProdNameTb);
            this.Controls.Add(this.ProdIdTb);
            this.Controls.Add(this.CustomHome);
            this.Controls.Add(this.CustomDelete);
            this.Controls.Add(this.CustomEdit2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductGv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProduct2";
            this.Text = "ö";
            this.Load += new System.EventHandler(this.ManageProduct2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ManageUsers_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView ProductGv;
        private System.Windows.Forms.Button CustomHome;
        private System.Windows.Forms.Button CustomDelete;
        private System.Windows.Forms.Button CustomEdit2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdQtyTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdIdTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdPriceTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdDescTb;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}