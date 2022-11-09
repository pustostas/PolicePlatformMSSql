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
    public partial class RSForm : Form
    {
        public RSForm()
        {
            InitializeComponent();
        }



        private void RSForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policePlatformDataSet.Cases' table. You can move, or remove it, as needed.
            this.casesTableAdapter.Fill(this.policePlatformDataSet.Cases);
            // TODO: This line of code loads data into the 'policePlatformDataSet.Criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter.Fill(this.policePlatformDataSet.Criminals);
            // TODO: This line of code loads data into the 'policePlatformDataSet.Criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter.Fill(this.policePlatformDataSet.Criminals);

        }

        private void criminalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.criminalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.policePlatformDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to accept changes?", "Changing data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                criminalsBindingSource.EndEdit();
                criminalsTableAdapter.Update(policePlatformDataSet);
                casesTableAdapter.Update(policePlatformDataSet);
            }
        }
    }
}
