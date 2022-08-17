namespace InventoryManagement
{
    partial class ManageCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ManageUsers_Load = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustomHome = new System.Windows.Forms.Button();
            this.CustomDelete = new System.Windows.Forms.Button();
            this.CustomEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CatNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoriesGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGv)).BeginInit();
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
            this.panel2.TabIndex = 21;
            // 
            // CustomHome
            // 
            this.CustomHome.BackColor = System.Drawing.Color.Crimson;
            this.CustomHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomHome.FlatAppearance.BorderSize = 0;
            this.CustomHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomHome.ForeColor = System.Drawing.Color.White;
            this.CustomHome.Location = new System.Drawing.Point(109, 384);
            this.CustomHome.Name = "CustomHome";
            this.CustomHome.Size = new System.Drawing.Size(75, 33);
            this.CustomHome.TabIndex = 25;
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
            this.CustomDelete.Location = new System.Drawing.Point(190, 332);
            this.CustomDelete.Name = "CustomDelete";
            this.CustomDelete.Size = new System.Drawing.Size(75, 33);
            this.CustomDelete.TabIndex = 24;
            this.CustomDelete.Text = "Delete";
            this.CustomDelete.UseVisualStyleBackColor = false;
            // 
            // CustomEdit
            // 
            this.CustomEdit.BackColor = System.Drawing.Color.Crimson;
            this.CustomEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomEdit.FlatAppearance.BorderSize = 0;
            this.CustomEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomEdit.ForeColor = System.Drawing.Color.White;
            this.CustomEdit.Location = new System.Drawing.Point(109, 332);
            this.CustomEdit.Name = "CustomEdit";
            this.CustomEdit.Size = new System.Drawing.Size(75, 33);
            this.CustomEdit.TabIndex = 23;
            this.CustomEdit.Text = "Edit";
            this.CustomEdit.UseVisualStyleBackColor = false;
            this.CustomEdit.Click += new System.EventHandler(this.CustomEdit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatNameTb
            // 
            this.CatNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTb.ForeColor = System.Drawing.Color.Crimson;
            this.CatNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatNameTb.HintText = "";
            this.CatNameTb.isPassword = false;
            this.CatNameTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.CatNameTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.CatNameTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.CatNameTb.LineThickness = 4;
            this.CatNameTb.Location = new System.Drawing.Point(28, 214);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(222, 42);
            this.CatNameTb.TabIndex = 27;
            this.CatNameTb.Text = "CategorieName";
            this.CatNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatIdTb
            // 
            this.CatIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIdTb.ForeColor = System.Drawing.Color.Crimson;
            this.CatIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatIdTb.HintText = "";
            this.CatIdTb.isPassword = false;
            this.CatIdTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.CatIdTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.CatIdTb.LineMouseHoverColor = System.Drawing.Color.DarkViolet;
            this.CatIdTb.LineThickness = 4;
            this.CatIdTb.Location = new System.Drawing.Point(28, 162);
            this.CatIdTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.Size = new System.Drawing.Size(222, 42);
            this.CatIdTb.TabIndex = 26;
            this.CatIdTb.Text = "CategoriesId";
            this.CatIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CatIdTb.OnValueChanged += new System.EventHandler(this.CustomerIdTb_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(582, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "CATEGORIES LIST";
            // 
            // CategoriesGv
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CategoriesGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoriesGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesGv.BackgroundColor = System.Drawing.Color.White;
            this.CategoriesGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriesGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoriesGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriesGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CategoriesGv.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriesGv.DefaultCellStyle = dataGridViewCellStyle6;
            this.CategoriesGv.EnableHeadersVisualStyles = false;
            this.CategoriesGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesGv.Location = new System.Drawing.Point(326, 176);
            this.CategoriesGv.Name = "CategoriesGv";
            this.CategoriesGv.RowHeadersVisible = false;
            this.CategoriesGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesGv.Size = new System.Drawing.Size(698, 386);
            this.CategoriesGv.TabIndex = 28;
            this.CategoriesGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoriesGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoriesGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoriesGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoriesGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.CategoriesGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoriesGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoriesGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoriesGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategoriesGv.ThemeStyle.HeaderStyle.Height = 20;
            this.CategoriesGv.ThemeStyle.ReadOnly = false;
            this.CategoriesGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoriesGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CategoriesGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoriesGv.ThemeStyle.RowsStyle.Height = 22;
            this.CategoriesGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1124, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoriesGv);
            this.Controls.Add(this.CatNameTb);
            this.Controls.Add(this.CatIdTb);
            this.Controls.Add(this.CustomHome);
            this.Controls.Add(this.CustomDelete);
            this.Controls.Add(this.CustomEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategories";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ManageUsers_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CustomHome;
        private System.Windows.Forms.Button CustomDelete;
        private System.Windows.Forms.Button CustomEdit;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatIdTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView CategoriesGv;
    }
}