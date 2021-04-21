namespace Penambahan_Barang
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Penambahan_Barang.AppData();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJumlahBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHargaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new Penambahan_Barang.AppDataTableAdapters.EmployeesTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(21, 177);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(109, 35);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.hargaBarangDataGridViewTextBoxColumn,
            this.jumlahBarangDataGridViewTextBoxColumn,
            this.kodeBarangDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView.DataSource = this.employeesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 288);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(776, 213);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Barang :";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.txtKodeBarang);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtJumlahBarang);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtHargaBarang);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtNamaBarang);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.btnBrowse);
            this.panel.Controls.Add(this.label1);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(776, 225);
            this.panel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kode Barang :";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "KodeBarang", true));
            this.txtKodeBarang.Location = new System.Drawing.Point(300, 108);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(366, 26);
            this.txtKodeBarang.TabIndex = 10;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 111);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 9;
            // 
            // txtJumlahBarang
            // 
            this.txtJumlahBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "JumlahBarang", true));
            this.txtJumlahBarang.Location = new System.Drawing.Point(300, 76);
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.Size = new System.Drawing.Size(366, 26);
            this.txtJumlahBarang.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jumlah Barang :";
            // 
            // txtHargaBarang
            // 
            this.txtHargaBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "HargaBarang", true));
            this.txtHargaBarang.Location = new System.Drawing.Point(300, 44);
            this.txtHargaBarang.Name = "txtHargaBarang";
            this.txtHargaBarang.Size = new System.Drawing.Size(366, 26);
            this.txtHargaBarang.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Harga Barang :";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "NamaBarang", true));
            this.txtNamaBarang.Location = new System.Drawing.Point(300, 12);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(366, 26);
            this.txtNamaBarang.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesBindingSource, "Image", true));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(133, 159);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(86, 256);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(702, 26);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Search :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(568, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(453, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(338, 507);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 35);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(223, 507);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(107, 35);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
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
            this.employeeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.Width = 120;
            // 
            // hargaBarangDataGridViewTextBoxColumn
            // 
            this.hargaBarangDataGridViewTextBoxColumn.DataPropertyName = "HargaBarang";
            this.hargaBarangDataGridViewTextBoxColumn.HeaderText = "HargaBarang";
            this.hargaBarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaBarangDataGridViewTextBoxColumn.Name = "hargaBarangDataGridViewTextBoxColumn";
            // 
            // jumlahBarangDataGridViewTextBoxColumn
            // 
            this.jumlahBarangDataGridViewTextBoxColumn.DataPropertyName = "JumlahBarang";
            this.jumlahBarangDataGridViewTextBoxColumn.HeaderText = "JumlahBarang";
            this.jumlahBarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jumlahBarangDataGridViewTextBoxColumn.Name = "jumlahBarangDataGridViewTextBoxColumn";
            this.jumlahBarangDataGridViewTextBoxColumn.Width = 180;
            // 
            // kodeBarangDataGridViewTextBoxColumn
            // 
            this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "KodeBarang";
            this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "KodeBarang";
            this.kodeBarangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
            this.kodeBarangDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.MinimumWidth = 8;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(681, 507);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 35);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJumlahBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHargaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private AppData appData;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private AppDataTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Button btnDelete;
    }
}

