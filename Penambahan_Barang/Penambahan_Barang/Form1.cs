using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penambahan_Barang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    dataGridView.DataSource = employeesBindingSource;
                else
                {
                    var query = from o in this.appData.Employees
                                where o.NamaBarang.Contains(txtSearch.Text) || o.HargaBarang == txtSearch.Text || o.JumlahBarang == txtSearch.Text || o.KodeBarang.Contains(txtSearch.Text)
                                select o;
                    dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    employeesBindingSource.RemoveCurrent();
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtNamaBarang.Focus();
                this.appData.Employees.AddEmployeesRow(this.appData.Employees.NewEmployeesRow());
                employeesBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeesBindingSource.ResetBindings(false);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtNamaBarang.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            employeesBindingSource.ResetBindings(false);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                employeesBindingSource.EndEdit();
                employeesTableAdapter.Update(this.appData.Employees);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeesBindingSource.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.appData.Employees);
            employeesBindingSource.DataSource = this.appData.Employees;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda akan menghapus data nya?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                employeesBindingSource.RemoveCurrent();
        }
    }
}
