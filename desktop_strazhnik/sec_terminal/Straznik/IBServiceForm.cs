using SQLLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Straznik
{
    /// <summary>
    /// Форма сотрудника службы ИБ
    /// </summary>
    public partial class IBServiceForm : Form
    {
        /// <summary>
        /// Библиотека для работы с БД
        /// </summary>
        SQL _sql = new SQL();
        /// <summary>
        /// Таблица верификации
        /// </summary>
        DataTable dt;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public IBServiceForm()
        {
            InitializeComponent();

            string name = _sql.ExecuteScalar($"select fio from users where login = '{LoginForm.login}'");
            string firstname = name.Split(' ')[0];
            string lastname = name.Split(' ')[1];
            string middlename = name.Split(' ')[2];
            lastname = lastname.First().ToString();
            middlename = firstname.First().ToString();
            name = firstname + " " + lastname + "." + middlename + ".";
            nameLabel.Text = name;
        }
        /// <summary>
        /// Действия при загрузке формы
        /// </summary>
        private void IBServiceForm_Load(object sender, EventArgs e)
        {
            dt = _sql.ReturnDataTable("SELECT fio,sex,position, secret,login,password,accepted from users WHERE login is null;");
            verifyDataGrid.DataSource = dt;

            verifyDataGrid.Columns[0].HeaderText = "ФИО";
            verifyDataGrid.Columns[1].HeaderText = "Пол";
            verifyDataGrid.Columns[2].HeaderText = "Должность";
            verifyDataGrid.Columns[3].HeaderText = "Секретное слово";
            verifyDataGrid.Columns[4].HeaderText = "Логин";
            verifyDataGrid.Columns[5].HeaderText = "Пароль";
            verifyDataGrid.Columns[6].HeaderText = "Одобрить";

            DataTable dt_mandats = _sql.ReturnDataTable("SELECT users.fio, users.position, entry_mandats.add_data, entry_mandats.read_data, entry_mandats.create_reports from entry_mandats inner join users on users.id = entry_mandats.user_id where entry_mandats.add_data = 0 or entry_mandats.read_data = 0 or entry_mandats.create_reports = 0;");
            mandatsDataGrid.DataSource = dt_mandats;
            mandatsDataGrid.Columns[0].HeaderText = "ФИО";
            mandatsDataGrid.Columns[1].HeaderText = "Должность";
            mandatsDataGrid.Columns[2].HeaderText = "Добавление данных";
            mandatsDataGrid.Columns[3].HeaderText = "Просмотр данных";
            mandatsDataGrid.Columns[4].HeaderText = "Формирование отчетов";
        }
        /// <summary>
        /// Действия при нажатии кнопки ExitButton
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Действия при нажатии кнопки veifyUser
        /// </summary>
        private void veifyUser_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow[] row = new DataGridViewRow[1];
                verifyDataGrid.SelectedRows.CopyTo(row, 0);
                string name = ((DataGridViewRow)row.GetValue(0)).Cells[0].Value.ToString();
                string secret = ((DataGridViewRow)row.GetValue(0)).Cells[3].Value.ToString();
                string login = ((DataGridViewRow)row.GetValue(0)).Cells[4].Value.ToString();
                string password = ((DataGridViewRow)row.GetValue(0)).Cells[5].Value.ToString();

                _sql.ExecuteNonQuery($"UPDATE users SET secret = '{secret}', login = '{login}', password = '{password}', type_id = {userTypeComboBox.SelectedIndex + 1}, accepted = '1' where fio = '{name}';");

                MessageBox.Show("Пользователь изменен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                verifyDataGrid.DataSource = dt;

                verifyDataGrid.Columns[0].HeaderText = "ФИО";
                verifyDataGrid.Columns[1].HeaderText = "Пол";
                verifyDataGrid.Columns[2].HeaderText = "Должность";
                verifyDataGrid.Columns[3].HeaderText = "Секретное слово";
                verifyDataGrid.Columns[4].HeaderText = "Логин";
                verifyDataGrid.Columns[5].HeaderText = "Пароль";
                verifyDataGrid.Columns[6].HeaderText = "Одобрить";
            }
            catch
            {
                MessageBox.Show("Вы не выбрали персону для одобрения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Действия при нажатии кнопки executeMandatsButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void executeMandatsButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow[] row = new DataGridViewRow[1];
                mandatsDataGrid.SelectedRows.CopyTo(row, 0);
                string name = ((DataGridViewRow)row.GetValue(0)).Cells[0].Value.ToString();
                string add_data = ((DataGridViewRow)row.GetValue(0)).Cells[2].Value.ToString();
                string read_data = ((DataGridViewRow)row.GetValue(0)).Cells[3].Value.ToString();
                string create_reports = ((DataGridViewRow)row.GetValue(0)).Cells[4].Value.ToString();

                _sql.ExecuteNonQuery($"UPDATE entry_mandats set add_data = '{add_data}', read_data = '{read_data}', create_reports = '{create_reports}' where user_id = (SELECT id FROM users WHERE fio = '{name}');");

                MessageBox.Show("Пользователь изменен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataTable dt_mandats = _sql.ReturnDataTable("SELECT users.fio, users.position, entry_mandats.add_data, entry_mandats.read_data, entry_mandats.create_reports from entry_mandats inner join users on users.id = entry_mandats.user_id where entry_mandats.add_data = 0 or entry_mandats.read_data = 0 or entry_mandats.create_reports = 0;");
                mandatsDataGrid.DataSource = dt_mandats;
                mandatsDataGrid.Columns[0].HeaderText = "ФИО";
                mandatsDataGrid.Columns[1].HeaderText = "Должность";
                mandatsDataGrid.Columns[2].HeaderText = "Добавление данных";
                mandatsDataGrid.Columns[3].HeaderText = "Просмотр данных";
                mandatsDataGrid.Columns[4].HeaderText = "Формирование отчетов";
            }
            catch
            {
                MessageBox.Show("Вы не выбрали персону для одобрения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
