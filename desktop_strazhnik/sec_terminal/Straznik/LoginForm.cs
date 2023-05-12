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
    /// Форма авторизации
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Логин пользователя, вошедшего в систему
        /// </summary>
        public static string login { get; set; }
        /// <summary>
        /// Библиотека для SQL-запросов
        /// </summary>
        SQL _sql = new SQL();
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Действия по кнопке loginButton
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string ret = _sql.ExecuteScalar($"SELECT id FROM users WHERE secret = '{secretTextBox.Text}' and login = '{loginTextBox.Text}' and password = '{passwordTextBox.Text}';");
                if (ret != null)
                {
                    ret = _sql.ExecuteScalar($"SELECT type_id FROM users WHERE login = '{loginTextBox.Text}';");
                    if (ret == "1" && typeComboBox.SelectedIndex == 0)
                    {
                        ret = _sql.ExecuteScalar($"SELECT blocked FROM users WHERE login = '{loginTextBox.Text}';");
                        if (ret == "True")
                        {
                            login = loginTextBox.Text;
                            Task.Delay(10000).Wait();
                            _sql.ExecuteNonQuery($"update users set blocked = '0' where login = '{loginTextBox.Text}'");
                            EntryAdminForm entryAdmin = new EntryAdminForm();
                            entryAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            login = loginTextBox.Text;
                            EntryAdminForm entryAdmin = new EntryAdminForm();
                            entryAdmin.Show();
                            this.Hide();
                        }
                    }
                    else if (ret == "2" && typeComboBox.SelectedIndex == 1)
                    {
                        ret = _sql.ExecuteScalar($"SELECT blocked FROM users WHERE login = '{loginTextBox.Text}';");
                        if (ret == "True")
                        {
                            login = loginTextBox.Text;
                            Task.Delay(10000).Wait();
                            _sql.ExecuteNonQuery($"update users set blocked = '0' where login = '{loginTextBox.Text}'");
                            IBServiceForm IBService = new IBServiceForm();
                            IBService.Show();
                            this.Hide();
                        }
                        else
                        {
                            login = loginTextBox.Text;
                            IBServiceForm IBService = new IBServiceForm();
                            IBService.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка с соединением либо вы набрали неправильный пароль.\nПопробуйте ещё раз, если ошибка остается - обратитесь к системному администратору", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Действия по кнопке resetPasswordButton
        /// </summary>
        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция не реализована", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
