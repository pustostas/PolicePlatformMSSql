namespace PolicePlatformMSSql
{
    partial class EditForm
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
            System.Windows.Forms.Label criminal_idLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label surnameLabel;
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Article = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Citizen = new System.Windows.Forms.ComboBox();
            this.citizensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.policePlatformDataSet = new PolicePlatformMSSql.PolicePlatformDataSet();
            this.comboBox_Criminal = new System.Windows.Forms.ComboBox();
            this.criminalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citizensTableAdapter = new PolicePlatformMSSql.PolicePlatformDataSetTableAdapters.CitizensTableAdapter();
            this.criminalsTableAdapter = new PolicePlatformMSSql.PolicePlatformDataSetTableAdapters.CriminalsTableAdapter();
            this.casesTableAdapter1 = new PolicePlatformMSSql.PolicePlatformDataSetTableAdapters.CasesTableAdapter();
            criminal_idLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.citizensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policePlatformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // criminal_idLabel
            // 
            criminal_idLabel.AutoSize = true;
            criminal_idLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            criminal_idLabel.Location = new System.Drawing.Point(12, 17);
            criminal_idLabel.Name = "criminal_idLabel";
            criminal_idLabel.Size = new System.Drawing.Size(64, 21);
            criminal_idLabel.TabIndex = 23;
            criminal_idLabel.Text = "Стаття:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            last_nameLabel.Location = new System.Drawing.Point(12, 62);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(124, 21);
            last_nameLabel.TabIndex = 25;
            last_nameLabel.Text = "Дата подання:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            first_nameLabel.Location = new System.Drawing.Point(12, 111);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(79, 21);
            first_nameLabel.TabIndex = 27;
            first_nameLabel.Text = "Заявник:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameLabel.Location = new System.Drawing.Point(12, 157);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(141, 21);
            surnameLabel.TabIndex = 29;
            surnameLabel.Text = "Обвинувачений:";
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(40, 242);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(122, 39);
            this.button_OK.TabIndex = 45;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(210, 242);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(126, 39);
            this.button_Cancel.TabIndex = 46;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_Article
            // 
            this.textBox_Article.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Article.Location = new System.Drawing.Point(159, 14);
            this.textBox_Article.Name = "textBox_Article";
            this.textBox_Article.Size = new System.Drawing.Size(200, 28);
            this.textBox_Article.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // comboBox_Citizen
            // 
            this.comboBox_Citizen.DataSource = this.citizensBindingSource;
            this.comboBox_Citizen.DisplayMember = "Last_name";
            this.comboBox_Citizen.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Citizen.FormattingEnabled = true;
            this.comboBox_Citizen.Location = new System.Drawing.Point(159, 108);
            this.comboBox_Citizen.Name = "comboBox_Citizen";
            this.comboBox_Citizen.Size = new System.Drawing.Size(200, 29);
            this.comboBox_Citizen.TabIndex = 49;
            this.comboBox_Citizen.ValueMember = "Citizen_id";
            // 
            // citizensBindingSource
            // 
            this.citizensBindingSource.DataMember = "Citizens";
            this.citizensBindingSource.DataSource = this.bindingSource1;
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
            // comboBox_Criminal
            // 
            this.comboBox_Criminal.DataSource = this.criminalsBindingSource;
            this.comboBox_Criminal.DisplayMember = "Last_name";
            this.comboBox_Criminal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Criminal.FormattingEnabled = true;
            this.comboBox_Criminal.Location = new System.Drawing.Point(159, 154);
            this.comboBox_Criminal.Name = "comboBox_Criminal";
            this.comboBox_Criminal.Size = new System.Drawing.Size(200, 29);
            this.comboBox_Criminal.TabIndex = 50;
            this.comboBox_Criminal.ValueMember = "Criminal_id";
            // 
            // criminalsBindingSource
            // 
            this.criminalsBindingSource.DataMember = "Criminals";
            this.criminalsBindingSource.DataSource = this.bindingSource1;
            // 
            // citizensTableAdapter
            // 
            this.citizensTableAdapter.ClearBeforeFill = true;
            // 
            // criminalsTableAdapter
            // 
            this.criminalsTableAdapter.ClearBeforeFill = true;
            // 
            // casesTableAdapter1
            // 
            this.casesTableAdapter1.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 305);
            this.Controls.Add(this.comboBox_Criminal);
            this.Controls.Add(this.comboBox_Citizen);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Article);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(criminal_idLabel);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(surnameLabel);
            this.Name = "EditForm";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.citizensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policePlatformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Article;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_Citizen;
        private System.Windows.Forms.ComboBox comboBox_Criminal;
        private System.Windows.Forms.BindingSource bindingSource1;
        private PolicePlatformDataSet policePlatformDataSet;
        private System.Windows.Forms.BindingSource citizensBindingSource;
        private PolicePlatformDataSetTableAdapters.CitizensTableAdapter citizensTableAdapter;
        private System.Windows.Forms.BindingSource criminalsBindingSource;
        private PolicePlatformDataSetTableAdapters.CriminalsTableAdapter criminalsTableAdapter;
        private PolicePlatformDataSetTableAdapters.CasesTableAdapter casesTableAdapter1;
    }
}