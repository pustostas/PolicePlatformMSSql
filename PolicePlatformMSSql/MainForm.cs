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

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
