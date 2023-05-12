using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;


namespace DesktopHranitel
{
    /// <summary>
    /// Форма сотрудника охранны ХранительПро
    /// </summary>
    public partial class DefenderUserForm : Form
    {
        public DefenderUserForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Реализация кнопки для поиска людей из групповой подачи
        /// </summary>
        private void findGroupButton_Click(object sender, EventArgs e)
        {
            SQL LibSql = new SQL();
            DataTable dt = LibSql.ReturnDataTable($"SELECT fio,phone,email,birthday,passport,(SELECT group_name FROM groups WHERE users_group.group_id = groups.id), date,onBlackList, accepted FROM users_group where fio = '{groupFIOTextBox.Text}' or passport = '{groupPassportTextBox.Text}';");

            groupUsersDataGrid.DataSource = dt;

            for (int i = 0; i < groupUsersDataGrid.Rows.Count - 1; i++)
            {
                if (groupUsersDataGrid.Rows[i].Cells[7].Value.ToString() == "True")
                {
                    DataGridViewCellStyle dgStyle = new DataGridViewCellStyle();
                    dgStyle.BackColor = Color.Red;
                    groupUsersDataGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        /// <summary>
        /// Реализация кнопки для поиска людей из индивидуальной подачи
        /// </summary>
        private void indEntryFindButton_Click(object sender, EventArgs e)
        {
            SQL LibSql = new SQL();
            DataTable dt = LibSql.ReturnDataTable($"SELECT fio,phone,email,birthday,passport, date,onBlackList, accepted FROM users_private where fio = '{groupFIOTextBox.Text}' or passport = '{groupPassportTextBox.Text}';");

            indDataGrid.DataSource = dt;

            for (int i = 0; i < indDataGrid.Rows.Count - 1; i++)
            {
                if (indDataGrid.Rows[i].Cells[7].Value.ToString() == "True")
                {
                    DataGridViewCellStyle dgStyle = new DataGridViewCellStyle();
                    dgStyle.BackColor = Color.Red;
                    indDataGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        /// <summary>
        /// Функция при загрузке формы (стандартная)
        /// </summary>
        private void DefenderUserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user06DataSet3.users_group". При необходимости она может быть перемещена или удалена.
            this.users_groupTableAdapter.Fill(this.user06DataSet3.users_group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user06DataSet2.users_private". При необходимости она может быть перемещена или удалена.
            this.users_privateTableAdapter.Fill(this.user06DataSet2.users_private);

        }
        /// <summary>
        /// Реализация кнопки для подробного просмотра посетителя
        /// </summary>
        private void aboutUserPrivateButton_Click(object sender, EventArgs e)
        {
            indEntryForm indEntryForm = new indEntryForm();
            indEntryForm.Show();
        }
        /// <summary>
        /// Реализация кнопки для подробного просмотра посетителя
        /// </summary>
        private void aboutUserGroupButton_Click(object sender, EventArgs e)
        {
            indEntryForm indEntryForm = new indEntryForm();
            indEntryForm.Show();
        }
    }
}
