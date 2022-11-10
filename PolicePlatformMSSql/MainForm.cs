using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicePlatformMSSql
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policePlatformDataSet.Criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter.Fill(this.policePlatformDataSet.Criminals);
            // TODO: This line of code loads data into the 'policePlatformDataSet.Citizens' table. You can move, or remove it, as needed.
            this.citizensTableAdapter.Fill(this.policePlatformDataSet.Citizens);
            // TODO: This line of code loads data into the 'policePlatformDataSet.Cases' table. You can move, or remove it, as needed.
            this.casesTableAdapter.Fill(this.policePlatformDataSet.Cases);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            casesTableAdapter.Update(policePlatformDataSet);
            criminalsTableAdapter.Update(policePlatformDataSet);
            citizensTableAdapter.Update(policePlatformDataSet);
        }

        private void criminalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            casesTableAdapter.Update(policePlatformDataSet);
            criminalsTableAdapter.Update(policePlatformDataSet);
            citizensTableAdapter.Update(policePlatformDataSet);
            bindingNavigator1.BindingSource = criminalsBindingSource;
            dataGridView1.DataSource = criminalsBindingSource;
            label1.Text = "Criminals";
        }

        private void citizensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            casesTableAdapter.Update(policePlatformDataSet);
            criminalsTableAdapter.Update(policePlatformDataSet);
            citizensTableAdapter.Update(policePlatformDataSet);
            bindingNavigator1.BindingSource = citizensBindingSource;
            dataGridView1.DataSource = citizensBindingSource;
            label1.Text = "Citizens";
        }

        private void casesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            casesTableAdapter.Update(policePlatformDataSet);
            criminalsTableAdapter.Update(policePlatformDataSet);
            citizensTableAdapter.Update(policePlatformDataSet);
            bindingNavigator1.BindingSource = casesBindingSource;
            dataGridView1.DataSource = casesBindingSource;
            label1.Text = "Cases";
        }

        private void casesOfCriminalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new RSForm();
            rs.ShowDialog();
            casesTableAdapter.Fill(policePlatformDataSet.Cases);
            citizensTableAdapter.Fill(policePlatformDataSet.Citizens);
            criminalsTableAdapter.Fill(policePlatformDataSet.Criminals);
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();
        }
        private bool edit = true;
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new EditForm();
            edt.ShowDialog();
            casesTableAdapter.Fill(policePlatformDataSet.Cases);
            policePlatformDataSet.AcceptChanges();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new PolicePlatformDataSet.CasesDataTable();
            casesTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new EditForm(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            Convert.ToDateTime(row[2]),
            Convert.ToInt32(row[3]),
            Convert.ToInt32(row[4])
            );
            edt.ShowDialog();
            casesTableAdapter.Fill(policePlatformDataSet.Cases);
            policePlatformDataSet.AcceptChanges();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            casesTableAdapter.DeleteQuery(
            Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
            );
            casesTableAdapter.Fill(policePlatformDataSet.Cases);
            policePlatformDataSet.AcceptChanges();
        }
    }
}
