using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopHranitel
{
    public partial class SubUnitUserForm : Form
    {
        /// <summary>
        /// Инициализация класса SQL библиотеки ClassLibrary
        /// </summary>
        SQL _sql = new SQL();

        /// <summary>
        /// Класс формы сотрудника подразделения
        /// </summary>
        public SubUnitUserForm()
        {
            InitializeComponent();

            // group
            DataTable dt = _sql.ReturnDataTable("SELECT fio,phone,email,birthday,passport,(SELECT group_name FROM groups WHERE groups.id = users_group.group_id), date,onBlackList,accepted FROM users_group WHERE accepted = '1';");
            groupUsersDataGrid.DataSource = dt;
            groupUsersDataGrid.Columns[0].HeaderText = "ФИО";
            groupUsersDataGrid.Columns[1].HeaderText = "Телефон";
            groupUsersDataGrid.Columns[2].HeaderText = "E-Mail";
            groupUsersDataGrid.Columns[3].HeaderText = "Дата рождения";
            groupUsersDataGrid.Columns[4].HeaderText = "Паспорт";
            groupUsersDataGrid.Columns[5].HeaderText = "Название группы";
            groupUsersDataGrid.Columns[6].HeaderText = "Дата посещения";
            groupUsersDataGrid.Columns[7].HeaderText = "В черном листе?";
            groupUsersDataGrid.Columns[8].HeaderText = "Доступ разрешен?";

            // ind
            dt = _sql.ReturnDataTable("SELECT fio,phone,email,birthday,passport, date, comments, (SELECT name FROM organizations WHERE organizations.id = users_private.organization), onBlackList,accepted FROM users_private WHERE accepted = '1';");
            indDataGrid.DataSource = dt;
            indDataGrid.Columns[0].HeaderText = "ФИО";
            indDataGrid.Columns[1].HeaderText = "Телефон";
            indDataGrid.Columns[2].HeaderText = "E-Mail";
            indDataGrid.Columns[3].HeaderText = "Дата рождения";
            indDataGrid.Columns[4].HeaderText = "Паспорт";;
            indDataGrid.Columns[5].HeaderText = "Дата посещения";
            indDataGrid.Columns[6].HeaderText = "Комментарий";
            indDataGrid.Columns[7].HeaderText = "Организация";
            indDataGrid.Columns[8].HeaderText = "В черном листе?";
            indDataGrid.Columns[9].HeaderText = "Доступ разрешен?";

            try
            {
                using (new FileStream(@"C:\\Users\Public\Documents\Отчеты_ТБ\", FileMode.Create))
                {

                }
            }
            catch
            {
            }
        }
        /// <summary>
        /// Действия по нажатию кнопки OrderByButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">событие</param>
        private void OrderByButton_Click(object sender, EventArgs e)
        {
            string _dateEntering = dateEnteringGroup.Value.ToString("yyyy-MM-dd");
            DataTable dt = _sql.ReturnDataTable($"SELECT fio,phone,email,birthday,passport,(SELECT group_name FROM groups WHERE groups.id = users_group.group_id), date,onBlackList,accepted FROM users_group WHERE date = '{_dateEntering}' and accepted = '1';");
            groupUsersDataGrid.DataSource = dt;
            groupUsersDataGrid.DataSource = dt;
            groupUsersDataGrid.Columns[0].HeaderText = "ФИО";
            groupUsersDataGrid.Columns[1].HeaderText = "Телефон";
            groupUsersDataGrid.Columns[2].HeaderText = "E-Mail";
            groupUsersDataGrid.Columns[3].HeaderText = "Дата рождения";
            groupUsersDataGrid.Columns[4].HeaderText = "Паспорт";
            groupUsersDataGrid.Columns[5].HeaderText = "Название группы";
            groupUsersDataGrid.Columns[6].HeaderText = "Дата посещения";
            groupUsersDataGrid.Columns[7].HeaderText = "В черном листе?";
            groupUsersDataGrid.Columns[8].HeaderText = "Доступ разрешен?";
        }
        /// <summary>
        /// Действия по нажатию кнопки OrderByButtonInd
        /// </summary>
        private void OrderByButtonInd_Click(object sender, EventArgs e)
        {
            string _dateEntering = indDateEntering.Value.ToString("yyyy-MM-dd");
            DataTable dt = _sql.ReturnDataTable($"SELECT fio,phone,email,birthday,passport, date, comments, (SELECT name FROM organizations WHERE organizations.id = users_private.organization), onBlackList,accepted FROM users_private WHERE date = {_dateEntering} and accepted = '1';");
            indDataGrid.DataSource = dt;
            indDataGrid.Columns[0].HeaderText = "ФИО";
            indDataGrid.Columns[1].HeaderText = "Телефон";
            indDataGrid.Columns[2].HeaderText = "E-Mail";
            indDataGrid.Columns[3].HeaderText = "Дата рождения";
            indDataGrid.Columns[4].HeaderText = "Паспорт"; ;
            indDataGrid.Columns[5].HeaderText = "Дата посещения";
            indDataGrid.Columns[6].HeaderText = "Комментарий";
            indDataGrid.Columns[7].HeaderText = "Организация";
            indDataGrid.Columns[8].HeaderText = "В черном листе?";
            indDataGrid.Columns[9].HeaderText = "Доступ разрешен?";
        }
        /// <summary>
        /// Действия по нажатию кнопки openUserDataGroup
        /// </summary>
        private void openUserDataGroup_Click(object sender, EventArgs e)
        {
            indEntryForm indEntryForm = new indEntryForm();
            indEntryForm.Show();
        }
        /// <summary>
        /// Действия по нажатию кнопки OpenIndUserData
        /// </summary>
        private void OpenIndUserData_Click(object sender, EventArgs e)
        {
            indEntryForm indEntryForm = new indEntryForm();
            indEntryForm.Show();
        }

        private void AddIndUserToBlackList_Click(object sender, EventArgs e)
        {
            try
            {
                _sql.ExecuteNonQuery($"update users_private set onBlackList = 1 where fio = '{AddIndUserToBlackList.Text}'");

                MessageBox.Show("Пользователь с ФИО занесен в черный список.", "Отчет", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Пользователь с данным ФИО не найден", "Ошибка!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void AddGroupToBlackList_Click(object sender, EventArgs e)
        {
            try
            {
                _sql.ExecuteNonQuery($"update users_group set onBlackList = 1 where fio = '{AddGroupToBlackList.Text}'");

                MessageBox.Show("Пользователь с ФИО занесен в черный список.", "Отчет", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Пользователь с данным ФИО не найден", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }
    }
}
