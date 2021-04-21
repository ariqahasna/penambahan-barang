using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaMart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtsearch.Text))
                {
                    this.employeesTableAdapter.Fill(this.appData.Employees);
                    employeesBindingSource.DataSource = this.appData.Employees;
                }
                else
                {
                    var query = from o in this.appData.Employees
                                where o.KodeBarang.Contains(txtsearch.Text) || o.NamaBarang == txtsearch.Text || o.BanyakBarang == txtsearch.Text || o.HargaBarang.Contains(txtsearch.Text)
                                select o;
                    employeesBindingSource.DataSource = query.ToList();
                }
            }
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Kamu yakin mau menghapus data ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    employeesBindingSource.RemoveCurrent();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtKodeBarang.Focus();
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
            txtKodeBarang.Focus();
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

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
