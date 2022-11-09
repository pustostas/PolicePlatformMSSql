namespace PolicePlatformMSSql
{
    partial class RSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSForm));
            System.Windows.Forms.Label criminal_idLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label registrationLabel;
            System.Windows.Forms.Label birth_dateLabel;
            System.Windows.Forms.Label passport_numberLabel;
            System.Windows.Forms.Label number_of_crimesLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label in_searchLabel;
            this.policePlatformDataSet = new PolicePlatformMSSql.PolicePlatformDataSet();
            this.criminalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criminalsTableAdapter = new PolicePlatformMSSql.PolicePlatformDataSetTableAdapters.CriminalsTableAdapter();
            this.tableAdapterManager = new PolicePlatformMSSql.PolicePlatformDataSetTableAdapters.TableAdapterManager();
            this.criminalsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.criminalsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.criminal_idTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.registrationTextBox = new System.Windows.Forms.TextBox();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passport_numberTextBox = new System.Windows.Forms.TextBox();
            this.number_of_crimesTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.in_searchCheckBox = new System.Windows.Forms.CheckBox();
            this.casesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casesTableAdapter = new PolicePlatformMSSql.PolicePlatformDataSetTableAdapters.CasesTableAdapter();
            this.casesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            criminal_idLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            registrationLabel = new System.Windows.Forms.Label();
            birth_dateLabel = new System.Windows.Forms.Label();
            passport_numberLabel = new System.Windows.Forms.Label();
            number_of_crimesLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            in_searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.policePlatformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingNavigator)).BeginInit();
            this.criminalsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // policePlatformDataSet
            // 
            this.policePlatformDataSet.DataSetName = "PolicePlatformDataSet";
            this.policePlatformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // criminalsBindingSource
            // 
            this.criminalsBindingSource.DataMember = "Criminals";
            this.criminalsBindingSource.DataSource = this.policePlatformDataSet;
            // 
            // criminalsTableAdapter
            // 
            this.criminalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasesTableAdapter = this.casesTableAdapter;
            this.tableAdapterManager.CitizensTableAdapter = null;
            this.tableAdapterManager.CriminalsTableAdapter = this.criminalsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PolicePlatformMSSql.PolicePlatformDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // criminalsBindingNavigator
            // 
            this.criminalsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.criminalsBindingNavigator.BindingSource = this.criminalsBindingSource;
            this.criminalsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.criminalsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.criminalsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.criminalsBindingNavigatorSaveItem});
            this.criminalsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.criminalsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.criminalsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.criminalsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.criminalsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.criminalsBindingNavigator.Name = "criminalsBindingNavigator";
            this.criminalsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.criminalsBindingNavigator.Size = new System.Drawing.Size(572, 25);
            this.criminalsBindingNavigator.TabIndex = 0;
            this.criminalsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // criminalsBindingNavigatorSaveItem
            // 
            this.criminalsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.criminalsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("criminalsBindingNavigatorSaveItem.Image")));
            this.criminalsBindingNavigatorSaveItem.Name = "criminalsBindingNavigatorSaveItem";
            this.criminalsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.criminalsBindingNavigatorSaveItem.Text = "Save Data";
            this.criminalsBindingNavigatorSaveItem.Click += new System.EventHandler(this.criminalsBindingNavigatorSaveItem_Click);
            // 
            // criminal_idLabel
            // 
            criminal_idLabel.AutoSize = true;
            criminal_idLabel.Location = new System.Drawing.Point(12, 36);
            criminal_idLabel.Name = "criminal_idLabel";
            criminal_idLabel.Size = new System.Drawing.Size(57, 13);
            criminal_idLabel.TabIndex = 1;
            criminal_idLabel.Text = "Criminal id:";
            // 
            // criminal_idTextBox
            // 
            this.criminal_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criminalsBindingSource, "Criminal_id", true));
            this.criminal_idTextBox.Location = new System.Drawing.Point(110, 33);
            this.criminal_idTextBox.Name = "criminal_idTextBox";
            this.criminal_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.criminal_idTextBox.TabIndex = 2;
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(12, 62);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(59, 13);
            last_nameLabel.TabIndex = 3;
            last_nameLabel.Text = "Last name:";
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criminalsBindingSource, "Last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(110, 59);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.last_nameTextBox.TabIndex = 4;
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(12, 88);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(58, 13);
            first_nameLabel.TabIndex = 5;
            first_nameLabel.Text = "First name:";
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criminalsBindingSource, "First_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(110, 85);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.first_nameTextBox.TabIndex = 6;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(12, 114);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 7;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criminalsBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(110, 111);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.surnameTextBox.TabIndex = 8;
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Location = new System.Drawing.Point(12, 140);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new System.Drawing.Size(66, 13);
            registrationLabel.TabIndex = 9;
            registrationLabel.Text = "Registration:";
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criminalsBindingSource, "Registration", true));
            this.registrationTextBox.Location = new System.Drawing.Point(110, 137);
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.Size = new System.Drawing.Size(200, 20);
            this.registrationTextBox.TabIndex = 10;
            // 
            // birth_dateLabel
            // 
            birth_dateLabel.AutoSize = true;
            birth_dateLabel.Location = new System.Drawing.Point(12, 167);
            birth_dateLabel.Name = "birth_dateLabel";
            birth_dateLabel.Size = new System.Drawing.Size(55, 13);
            birth_dateLabel.TabIndex = 11;
            birth_dateLabel.Text = "Birth date:";
            // 
            // birth_dateDateTimePicker
            // 
            this.birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.criminalsBindingSource, "Birth_date", true));
            this.birth_dateDateTimePicker.Location = new System.Drawing.Point(110, 163);
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            this.birth_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birth_dateDateTimePicker.TabIndex = 12;
            // 
            // passport_numberLabel
            // 
            passport_numberLabel.AutoSize = true;
            passport_numberLabel.Location = new System.Drawing.Point(12, 192);
            passport_numberLabel.Name = "passport_numberLabel";
            passport_numberLabel.Size = new System.Drawing.Size(89, 13);
            passport_numberLabel.TabIndex = 13;
            passport_numberLabel.Text = "Passport number:";
            // 
            // passport_numberTextBox
            // 
            this.passport_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criminalsBindingSource, "Passport_number", true));
            this.passport_numberTextBox.Location = new System.Drawing.Point(110, 189);
            this.passport_numberTextBox.Name = "passport_numberTextBox";
            this.passport_numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.passport_numberTextBox.TabIndex = 14;
            // 
            // number_of_crimesLabel
            // 
            number_of_crimesLabel.AutoSize = true;
            number_of_crimesLabel.Location = new System.Drawing.Point(12, 218);
            number_of_crimesLabel.Name = "number_of_crimesLabel";
            number_of_crimesLabel.Size = new System.Drawing.Size(92, 13);
            number_of_crimesLabel.TabIndex = 15;
            number_of_crimesLabel.Text = "Number of crimes:";
            // 
            // number_of_crimesTextBox
            // 
            this.number_of_crimesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criminalsBindingSource, "Number_of_crimes", true));
            this.number_of_crimesTextBox.Location = new System.Drawing.Point(110, 215);
            this.number_of_crimesTextBox.Name = "number_of_crimesTextBox";
            this.number_of_crimesTextBox.Size = new System.Drawing.Size(200, 20);
            this.number_of_crimesTextBox.TabIndex = 16;
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(12, 244);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(79, 13);
            phone_numberLabel.TabIndex = 17;
            phone_numberLabel.Text = "Phone number:";
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criminalsBindingSource, "Phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(110, 241);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phone_numberTextBox.TabIndex = 18;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 270);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criminalsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(110, 267);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 20;
            // 
            // in_searchLabel
            // 
            in_searchLabel.AutoSize = true;
            in_searchLabel.Location = new System.Drawing.Point(12, 298);
            in_searchLabel.Name = "in_searchLabel";
            in_searchLabel.Size = new System.Drawing.Size(54, 13);
            in_searchLabel.TabIndex = 21;
            in_searchLabel.Text = "In search:";
            // 
            // in_searchCheckBox
            // 
            this.in_searchCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.criminalsBindingSource, "In_search", true));
            this.in_searchCheckBox.Location = new System.Drawing.Point(110, 293);
            this.in_searchCheckBox.Name = "in_searchCheckBox";
            this.in_searchCheckBox.Size = new System.Drawing.Size(200, 24);
            this.in_searchCheckBox.TabIndex = 22;
            this.in_searchCheckBox.Text = "checkBox1";
            this.in_searchCheckBox.UseVisualStyleBackColor = true;
            // 
            // casesBindingSource
            // 
            this.casesBindingSource.DataMember = "FK__Cases__Criminal___286302EC";
            this.casesBindingSource.DataSource = this.criminalsBindingSource;
            // 
            // casesTableAdapter
            // 
            this.casesTableAdapter.ClearBeforeFill = true;
            // 
            // casesDataGridView
            // 
            this.casesDataGridView.AutoGenerateColumns = false;
            this.casesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.casesDataGridView.DataSource = this.casesBindingSource;
            this.casesDataGridView.Location = new System.Drawing.Point(15, 323);
            this.casesDataGridView.Name = "casesDataGridView";
            this.casesDataGridView.Size = new System.Drawing.Size(545, 220);
            this.casesDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Case_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Case_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Article";
            this.dataGridViewTextBoxColumn2.HeaderText = "Article";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date_of_receiving";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date_of_receiving";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Citizen_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Citizen_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Criminal_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Criminal_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(190, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 66);
            this.button1.TabIndex = 24;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.casesDataGridView);
            this.Controls.Add(criminal_idLabel);
            this.Controls.Add(this.criminal_idTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(registrationLabel);
            this.Controls.Add(this.registrationTextBox);
            this.Controls.Add(birth_dateLabel);
            this.Controls.Add(this.birth_dateDateTimePicker);
            this.Controls.Add(passport_numberLabel);
            this.Controls.Add(this.passport_numberTextBox);
            this.Controls.Add(number_of_crimesLabel);
            this.Controls.Add(this.number_of_crimesTextBox);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(in_searchLabel);
            this.Controls.Add(this.in_searchCheckBox);
            this.Controls.Add(this.criminalsBindingNavigator);
            this.Name = "RSForm";
            this.Text = "RSForm";
            this.Load += new System.EventHandler(this.RSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policePlatformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingNavigator)).EndInit();
            this.criminalsBindingNavigator.ResumeLayout(false);
            this.criminalsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PolicePlatformDataSet policePlatformDataSet;
        private System.Windows.Forms.BindingSource criminalsBindingSource;
        private PolicePlatformDataSetTableAdapters.CriminalsTableAdapter criminalsTableAdapter;
        private PolicePlatformDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator criminalsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton criminalsBindingNavigatorSaveItem;
        private PolicePlatformDataSetTableAdapters.CasesTableAdapter casesTableAdapter;
        private System.Windows.Forms.TextBox criminal_idTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox registrationTextBox;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.TextBox passport_numberTextBox;
        private System.Windows.Forms.TextBox number_of_crimesTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox in_searchCheckBox;
        private System.Windows.Forms.BindingSource casesBindingSource;
        private System.Windows.Forms.DataGridView casesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
    }
}