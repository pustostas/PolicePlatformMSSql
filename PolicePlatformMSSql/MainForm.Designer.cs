namespace PolicePlatformMSSql
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.policePlatformDataSet = new PolicePlatformMSSql.PolicePlatformDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.criminalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofcrimesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insearchDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.criminalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casesTableAdapter = new PolicePlatformMSSql.PolicePlatformDataSetTableAdapters.CasesTableAdapter();
            this.citizensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citizensTableAdapter = new PolicePlatformMSSql.PolicePlatformDataSetTableAdapters.CitizensTableAdapter();
            this.criminalsTableAdapter = new PolicePlatformMSSql.PolicePlatformDataSetTableAdapters.CriminalsTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criminalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citizensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casesOfCriminalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.editFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policePlatformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.policePlatformDataSet;
            this.bindingSource1.Position = 0;
            // 
            // policePlatformDataSet
            // 
            this.policePlatformDataSet.DataSetName = "PolicePlatformDataSet";
            this.policePlatformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.criminalidDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.registrationDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.passportnumberDataGridViewTextBoxColumn,
            this.numberofcrimesDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.insearchDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.criminalsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 536);
            this.dataGridView1.TabIndex = 0;
            // 
            // criminalidDataGridViewTextBoxColumn
            // 
            this.criminalidDataGridViewTextBoxColumn.DataPropertyName = "Criminal_id";
            this.criminalidDataGridViewTextBoxColumn.HeaderText = "Criminal_id";
            this.criminalidDataGridViewTextBoxColumn.Name = "criminalidDataGridViewTextBoxColumn";
            this.criminalidDataGridViewTextBoxColumn.Width = 82;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 84;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "First_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 83;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 74;
            // 
            // registrationDataGridViewTextBoxColumn
            // 
            this.registrationDataGridViewTextBoxColumn.DataPropertyName = "Registration";
            this.registrationDataGridViewTextBoxColumn.HeaderText = "Registration";
            this.registrationDataGridViewTextBoxColumn.Name = "registrationDataGridViewTextBoxColumn";
            this.registrationDataGridViewTextBoxColumn.Width = 88;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birth_date";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birth_date";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.Width = 80;
            // 
            // passportnumberDataGridViewTextBoxColumn
            // 
            this.passportnumberDataGridViewTextBoxColumn.DataPropertyName = "Passport_number";
            this.passportnumberDataGridViewTextBoxColumn.HeaderText = "Passport_number";
            this.passportnumberDataGridViewTextBoxColumn.Name = "passportnumberDataGridViewTextBoxColumn";
            this.passportnumberDataGridViewTextBoxColumn.Width = 114;
            // 
            // numberofcrimesDataGridViewTextBoxColumn
            // 
            this.numberofcrimesDataGridViewTextBoxColumn.DataPropertyName = "Number_of_crimes";
            this.numberofcrimesDataGridViewTextBoxColumn.HeaderText = "Number_of_crimes";
            this.numberofcrimesDataGridViewTextBoxColumn.Name = "numberofcrimesDataGridViewTextBoxColumn";
            this.numberofcrimesDataGridViewTextBoxColumn.Width = 120;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 104;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // insearchDataGridViewCheckBoxColumn
            // 
            this.insearchDataGridViewCheckBoxColumn.DataPropertyName = "In_search";
            this.insearchDataGridViewCheckBoxColumn.HeaderText = "In_search";
            this.insearchDataGridViewCheckBoxColumn.Name = "insearchDataGridViewCheckBoxColumn";
            this.insearchDataGridViewCheckBoxColumn.Width = 60;
            // 
            // criminalsBindingSource
            // 
            this.criminalsBindingSource.DataMember = "Criminals";
            this.criminalsBindingSource.DataSource = this.bindingSource1;
            // 
            // casesBindingSource
            // 
            this.casesBindingSource.DataMember = "Cases";
            this.casesBindingSource.DataSource = this.bindingSource1;
            // 
            // casesTableAdapter
            // 
            this.casesTableAdapter.ClearBeforeFill = true;
            // 
            // citizensBindingSource
            // 
            this.citizensBindingSource.DataMember = "Citizens";
            this.citizensBindingSource.DataSource = this.bindingSource1;
            // 
            // citizensTableAdapter
            // 
            this.citizensTableAdapter.ClearBeforeFill = true;
            // 
            // criminalsTableAdapter
            // 
            this.criminalsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.criminalsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(864, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criminalsToolStripMenuItem,
            this.citizensToolStripMenuItem,
            this.casesToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // criminalsToolStripMenuItem
            // 
            this.criminalsToolStripMenuItem.Name = "criminalsToolStripMenuItem";
            this.criminalsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.criminalsToolStripMenuItem.Text = "Criminals";
            this.criminalsToolStripMenuItem.Click += new System.EventHandler(this.criminalsToolStripMenuItem_Click);
            // 
            // citizensToolStripMenuItem
            // 
            this.citizensToolStripMenuItem.Name = "citizensToolStripMenuItem";
            this.citizensToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.citizensToolStripMenuItem.Text = "Citizens";
            this.citizensToolStripMenuItem.Click += new System.EventHandler(this.citizensToolStripMenuItem_Click);
            // 
            // casesToolStripMenuItem
            // 
            this.casesToolStripMenuItem.Name = "casesToolStripMenuItem";
            this.casesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.casesToolStripMenuItem.Text = "Cases";
            this.casesToolStripMenuItem.Click += new System.EventHandler(this.casesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casesOfCriminalsToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.editFormToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // casesOfCriminalsToolStripMenuItem
            // 
            this.casesOfCriminalsToolStripMenuItem.Name = "casesOfCriminalsToolStripMenuItem";
            this.casesOfCriminalsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.casesOfCriminalsToolStripMenuItem.Text = "Cases of criminals";
            this.casesOfCriminalsToolStripMenuItem.Click += new System.EventHandler(this.casesOfCriminalsToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queryToolStripMenuItem.Text = "QueryEdit";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Criminals";
            // 
            // editFormToolStripMenuItem
            // 
            this.editFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.editFormToolStripMenuItem.Name = "editFormToolStripMenuItem";
            this.editFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editFormToolStripMenuItem.Text = "EditForm";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policePlatformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private PolicePlatformDataSet policePlatformDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource casesBindingSource;
        private PolicePlatformDataSetTableAdapters.CasesTableAdapter casesTableAdapter;
        private System.Windows.Forms.BindingSource citizensBindingSource;
        private PolicePlatformDataSetTableAdapters.CitizensTableAdapter citizensTableAdapter;
        private System.Windows.Forms.BindingSource criminalsBindingSource;
        private PolicePlatformDataSetTableAdapters.CriminalsTableAdapter criminalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn criminalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofcrimesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn insearchDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criminalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citizensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casesOfCriminalsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}

