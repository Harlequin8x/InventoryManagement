namespace InventoryManagement
{
    partial class ManageCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ManageUsers_Load = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerPhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomersGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGv)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            // CustomerPhoneTb
            // 
            this.CustomerPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerPhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneTb.ForeColor = System.Drawing.Color.Crimson;
            this.CustomerPhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerPhoneTb.HintText = "";
            this.CustomerPhoneTb.isPassword = false;
            this.CustomerPhoneTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.CustomerPhoneTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.CustomerPhoneTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.CustomerPhoneTb.LineThickness = 4;
            this.CustomerPhoneTb.Location = new System.Drawing.Point(27, 248);
            this.CustomerPhoneTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CustomerPhoneTb.Name = "CustomerPhoneTb";
            this.CustomerPhoneTb.Size = new System.Drawing.Size(222, 42);
            this.CustomerPhoneTb.TabIndex = 7;
            this.CustomerPhoneTb.Text = "CustomerPhone";
            this.CustomerPhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerPhoneTb.OnValueChanged += new System.EventHandler(this.PasswordTb_OnValueChanged);
            // 
            // CustomerNameTb
            // 
            this.CustomerNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTb.ForeColor = System.Drawing.Color.Crimson;
            this.CustomerNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerNameTb.HintText = "";
            this.CustomerNameTb.isPassword = false;
            this.CustomerNameTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.CustomerNameTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.CustomerNameTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.CustomerNameTb.LineThickness = 4;
            this.CustomerNameTb.Location = new System.Drawing.Point(27, 196);
            this.CustomerNameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CustomerNameTb.Name = "CustomerNameTb";
            this.CustomerNameTb.Size = new System.Drawing.Size(222, 42);
            this.CustomerNameTb.TabIndex = 6;
            this.CustomerNameTb.Text = "CustomerName";
            this.CustomerNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerIdTb
            // 
            this.CustomerIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdTb.ForeColor = System.Drawing.Color.Crimson;
            this.CustomerIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerIdTb.HintText = "";
            this.CustomerIdTb.isPassword = false;
            this.CustomerIdTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.CustomerIdTb.LineIdleColor = System.Drawing.Color.DarkViolet;
            this.CustomerIdTb.LineMouseHoverColor = System.Drawing.Color.DarkViolet;
            this.CustomerIdTb.LineThickness = 4;
            this.CustomerIdTb.Location = new System.Drawing.Point(27, 144);
            this.CustomerIdTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CustomerIdTb.Name = "CustomerIdTb";
            this.CustomerIdTb.Size = new System.Drawing.Size(222, 42);
            this.CustomerIdTb.TabIndex = 5;
            this.CustomerIdTb.Text = "CustomerId";
            this.CustomerIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(594, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "CUSTOMER LIST";
            // 
            // CustomersGv
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.CustomersGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.CustomersGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersGv.BackgroundColor = System.Drawing.Color.White;
            this.CustomersGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomersGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomersGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.CustomersGv.ColumnHeadersHeight = 20;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersGv.DefaultCellStyle = dataGridViewCellStyle12;
            this.CustomersGv.EnableHeadersVisualStyles = false;
            this.CustomersGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersGv.Location = new System.Drawing.Point(338, 185);
            this.CustomersGv.Name = "CustomersGv";
            this.CustomersGv.RowHeadersVisible = false;
            this.CustomersGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGv.Size = new System.Drawing.Size(698, 386);
            this.CustomersGv.TabIndex = 14;
            this.CustomersGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomersGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomersGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomersGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomersGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomersGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomersGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.CustomersGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomersGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomersGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomersGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomersGv.ThemeStyle.HeaderStyle.Height = 20;
            this.CustomersGv.ThemeStyle.ReadOnly = false;
            this.CustomersGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomersGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomersGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomersGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomersGv.ThemeStyle.RowsStyle.Height = 22;
            this.CustomersGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(108, 424);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(189, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(108, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 614);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 19);
            this.panel2.TabIndex = 20;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomersGv);
            this.Controls.Add(this.CustomerPhoneTb);
            this.Controls.Add(this.CustomerNameTb);
            this.Controls.Add(this.CustomerIdTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCustomer";
            this.Text = "ManageCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ManageUsers_Load;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerPhoneTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerIdTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView CustomersGv;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}