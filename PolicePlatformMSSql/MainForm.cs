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
            bindingNavigator1.BindingSource = criminalsBindingSource;
            dataGridView1.DataSource = criminalsBindingSource;
            label1.Text = "Criminals";
        }

        private void citizensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = citizensBindingSource;
            dataGridView1.DataSource = citizensBindingSource;
            label1.Text = "Citizens";
        }

        private void casesToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}
