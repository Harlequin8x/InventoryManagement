namespace InventoryManagement
{
    partial class ManageProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ManageUsers_Load = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.QtyTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DescriptionTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.CustomHome = new System.Windows.Forms.Button();
            this.CustomDelete = new System.Windows.Forms.Button();
            this.CustomEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductsGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGv)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.ManageUsers_Load.Size = new System.Drawing.Size(212, 24);
            this.ManageUsers_Load.TabIndex = 1;
            this.ManageUsers_Load.Text = "Manage Customers";
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
            this.panel2.TabIndex = 22;
            // 
            // PriceTb
            // 
            this.PriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTb.ForeColor = System.Drawing.Color.Crimson;
            this.PriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.PriceTb.HintText = "";
            this.PriceTb.isPassword = false;
            this.PriceTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PriceTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.PriceTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PriceTb.LineThickness = 4;
            this.PriceTb.Location = new System.Drawing.Point(27, 296);
            this.PriceTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(222, 42);
            this.PriceTb.TabIndex = 26;
            this.PriceTb.Text = "ProductPrice";
            this.PriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // QtyTb
            // 
            this.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.ForeColor = System.Drawing.Color.Crimson;
            this.QtyTb.HintForeColor = System.Drawing.Color.Empty;
            this.QtyTb.HintText = "";
            this.QtyTb.isPassword = false;
            this.QtyTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.QtyTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.QtyTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.QtyTb.LineThickness = 4;
            this.QtyTb.Location = new System.Drawing.Point(27, 244);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(222, 42);
            this.QtyTb.TabIndex = 25;
            this.QtyTb.Text = "ProductQty";
            this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.ProdNameTb.Location = new System.Drawing.Point(27, 192);
            this.ProdNameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(222, 42);
            this.ProdNameTb.TabIndex = 24;
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
            this.ProdIdTb.Location = new System.Drawing.Point(27, 144);
            this.ProdIdTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdIdTb.Name = "ProdIdTb";
            this.ProdIdTb.Size = new System.Drawing.Size(222, 38);
            this.ProdIdTb.TabIndex = 23;
            this.ProdIdTb.Text = "ProductId";
            this.ProdIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProdIdTb.OnValueChanged += new System.EventHandler(this.unameTb_OnValueChanged);
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTb.ForeColor = System.Drawing.Color.Crimson;
            this.DescriptionTb.HintForeColor = System.Drawing.Color.Empty;
            this.DescriptionTb.HintText = "";
            this.DescriptionTb.isPassword = false;
            this.DescriptionTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DescriptionTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.DescriptionTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DescriptionTb.LineThickness = 4;
            this.DescriptionTb.Location = new System.Drawing.Point(27, 348);
            this.DescriptionTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(222, 42);
            this.DescriptionTb.TabIndex = 27;
            this.DescriptionTb.Text = "Description";
            this.DescriptionTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatCombo
            // 
            this.CatCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CatCombo.ForeColor = System.Drawing.Color.Crimson;
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(27, 398);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(222, 29);
            this.CatCombo.TabIndex = 28;
            this.CatCombo.Text = "Product Category";
            this.CatCombo.SelectedIndexChanged += new System.EventHandler(this.CatCombo_SelectedIndexChanged);
            // 
            // CustomHome
            // 
            this.CustomHome.BackColor = System.Drawing.Color.Crimson;
            this.CustomHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomHome.FlatAppearance.BorderSize = 0;
            this.CustomHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomHome.ForeColor = System.Drawing.Color.White;
            this.CustomHome.Location = new System.Drawing.Point(108, 510);
            this.CustomHome.Name = "CustomHome";
            this.CustomHome.Size = new System.Drawing.Size(75, 33);
            this.CustomHome.TabIndex = 32;
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
            this.CustomDelete.Location = new System.Drawing.Point(189, 458);
            this.CustomDelete.Name = "CustomDelete";
            this.CustomDelete.Size = new System.Drawing.Size(75, 33);
            this.CustomDelete.TabIndex = 31;
            this.CustomDelete.Text = "Delete";
            this.CustomDelete.UseVisualStyleBackColor = false;
            this.CustomDelete.Click += new System.EventHandler(this.CustomDelete_Click);
            // 
            // CustomEdit
            // 
            this.CustomEdit.BackColor = System.Drawing.Color.Crimson;
            this.CustomEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomEdit.FlatAppearance.BorderSize = 0;
            this.CustomEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomEdit.ForeColor = System.Drawing.Color.White;
            this.CustomEdit.Location = new System.Drawing.Point(108, 458);
            this.CustomEdit.Name = "CustomEdit";
            this.CustomEdit.Size = new System.Drawing.Size(75, 33);
            this.CustomEdit.TabIndex = 30;
            this.CustomEdit.Text = "Edit";
            this.CustomEdit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(602, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "PRODUCT LIST";
            // 
            // ProductsGv
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ProductsGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ProductsGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGv.BackgroundColor = System.Drawing.Color.White;
            this.ProductsGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProductsGv.ColumnHeadersHeight = 20;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGv.DefaultCellStyle = dataGridViewCellStyle9;
            this.ProductsGv.EnableHeadersVisualStyles = false;
            this.ProductsGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGv.Location = new System.Drawing.Point(341, 173);
            this.ProductsGv.Name = "ProductsGv";
            this.ProductsGv.RowHeadersVisible = false;
            this.ProductsGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGv.Size = new System.Drawing.Size(698, 370);
            this.ProductsGv.TabIndex = 33;
            this.ProductsGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductsGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductsGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductsGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductsGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.ProductsGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductsGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductsGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsGv.ThemeStyle.HeaderStyle.Height = 20;
            this.ProductsGv.ThemeStyle.ReadOnly = false;
            this.ProductsGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductsGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsGv.ThemeStyle.RowsStyle.Height = 22;
            this.ProductsGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGv_CellContentClick);
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductsGv);
            this.Controls.Add(this.CustomHome);
            this.Controls.Add(this.CustomDelete);
            this.Controls.Add(this.CustomEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.ProdNameTb);
            this.Controls.Add(this.ProdIdTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProduct";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ManageUsers_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QtyTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdIdTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DescriptionTb;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.Button CustomHome;
        private System.Windows.Forms.Button CustomDelete;
        private System.Windows.Forms.Button CustomEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsGv;
    }
}