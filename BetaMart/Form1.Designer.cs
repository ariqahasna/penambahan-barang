namespace BetaMart
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBanyakBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHargaBarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new BetaMart.AppData();
            this.employeesTableAdapter = new BetaMart.AppDataTableAdapters.EmployeesTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banyakBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(806, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.kodeBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.banyakBarangDataGridViewTextBoxColumn,
            this.hargaBarangDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.employeesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 192);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(906, 230);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Barang :";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtHargaBarang);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.txtBanyakBarang);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtNamaBarang);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtKodeBarang);
            this.panel.Controls.Add(this.label1);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(906, 109);
            this.panel.TabIndex = 3;
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "KodeBarang", true));
            this.txtKodeBarang.Location = new System.Drawing.Point(151, 16);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(280, 26);
            this.txtKodeBarang.TabIndex = 4;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "NamaBarang", true));
            this.txtNamaBarang.Location = new System.Drawing.Point(151, 64);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(280, 26);
            this.txtNamaBarang.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Barang :";
            // 
            // txtBanyakBarang
            // 
            this.txtBanyakBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BanyakBarang", true));
            this.txtBanyakBarang.Location = new System.Drawing.Point(616, 22);
            this.txtBanyakBarang.Name = "txtBanyakBarang";
            this.txtBanyakBarang.Size = new System.Drawing.Size(280, 26);
            this.txtBanyakBarang.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Banyak Barang: ";
            // 
            // txtHargaBarang
            // 
            this.txtHargaBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "HargaBarang", true));
            this.txtHargaBarang.Location = new System.Drawing.Point(616, 64);
            this.txtHargaBarang.Name = "txtHargaBarang";
            this.txtHargaBarang.Size = new System.Drawing.Size(280, 26);
            this.txtHargaBarang.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Harga Barang :";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(88, 151);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(830, 26);
            this.txtsearch.TabIndex = 12;
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtsearch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search :";
            this.label4.Click += new System.EventHandler(this.Label4_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(688, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(570, 428);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 34);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(452, 428);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 34);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // kodeBarangDataGridViewTextBoxColumn
            // 
            this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "KodeBarang";
            this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "KodeBarang";
            this.kodeBarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
            this.kodeBarangDataGridViewTextBoxColumn.Width = 120;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.Width = 120;
            // 
            // banyakBarangDataGridViewTextBoxColumn
            // 
            this.banyakBarangDataGridViewTextBoxColumn.DataPropertyName = "BanyakBarang";
            this.banyakBarangDataGridViewTextBoxColumn.HeaderText = "BanyakBarang";
            this.banyakBarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.banyakBarangDataGridViewTextBoxColumn.Name = "banyakBarangDataGridViewTextBoxColumn";
            this.banyakBarangDataGridViewTextBoxColumn.Width = 120;
            // 
            // hargaBarangDataGridViewTextBoxColumn
            // 
            this.hargaBarangDataGridViewTextBoxColumn.DataPropertyName = "HargaBarang";
            this.hargaBarangDataGridViewTextBoxColumn.HeaderText = "HargaBarang";
            this.hargaBarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaBarangDataGridViewTextBoxColumn.Name = "hargaBarangDataGridViewTextBoxColumn";
            this.hargaBarangDataGridViewTextBoxColumn.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 477);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beta Mart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtBanyakBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHargaBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private AppData appData;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private AppDataTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banyakBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBarangDataGridViewTextBoxColumn;
    }
}

