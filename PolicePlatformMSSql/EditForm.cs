using System;
using System.Windows.Forms;
namespace PolicePlatformMSSql
{
    public partial class EditForm : Form
    {
        /// <summary>
        /// Id студента
        /// </summary>
        private readonly int id;
        /// <summary>
        /// true - если запись модифицируется, false - если создаётся новая
        /// </summary>
        readonly bool edit;
        /// <summary>
        /// конструктор формы, для создания новой записи
        /// </summary>
        public EditForm()
        {
            InitializeComponent();
            citizensTableAdapter.Fill(policePlatformDataSet.Citizens);
            criminalsTableAdapter.Fill(policePlatformDataSet.Criminals);
            edit = false;
        }
        /// <summary>
        /// конструктор формы, для модификации уже существующей записи
        /// </summary>
        /// <param name="Article">ФИО</param>
        /// <param name="Date_of_receiving">Дата заселения</param>
        /// <param name="Citizen_id">Номер комнаты</param>
        /// <param name="Criminal_id">Паспорт</param>
        /// <param name="Case_id">ID студента</param>
        public EditForm(int Case_id, String Article, DateTime Date_of_receiving, int Citizen_id, int Criminal_id)
        : this()
        {
            citizensTableAdapter.Fill(policePlatformDataSet.Citizens);
            criminalsTableAdapter.Fill(policePlatformDataSet.Criminals);
            edit = true;
            this.id = Case_id;
            textBox_Article.Text = Article;
            dateTimePicker1.Value = Date_of_receiving;
            comboBox_Citizen.SelectedValue = Citizen_id;

            comboBox_Criminal.SelectedValue = Criminal_id;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                casesTableAdapter1.UpdateQuery(textBox_Article.Text, dateTimePicker1.Value.ToString(),
               Convert.ToInt32(comboBox_Citizen.SelectedValue),
               Convert.ToInt32(comboBox_Criminal.SelectedValue), id);
            }
            else
            {
                casesTableAdapter1.InsertQuery(textBox_Article.Text, dateTimePicker1.Value.ToString(),
               Convert.ToInt32(comboBox_Citizen.SelectedValue),
               Convert.ToInt32(comboBox_Criminal.SelectedValue));
            }
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

