using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopHranitel
{
    /// <summary>
    /// Форма для авторизации
    /// </summary>
    public partial class LoginForm : Form
    {
        static string connString = "Data Source=wsr-server;Initial Catalog=User06;User ID=User06;Password=NKSX4NHH";
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Код, исполняемый при нажатии кнопки "Войти"
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand($"SELECT id FROM employers where user_code = '{loginTextBox.Text}';", conn);
                string returnMessage = cmd1.ExecuteScalar().ToString();

                if (returnMessage != null || returnMessage != "0")
                {
                    SqlCommand cmd2 = new SqlCommand($"SELECT otdel FROM employers where user_code = '{loginTextBox.Text}';", conn);
                    returnMessage = cmd2.ExecuteScalar().ToString();
                    returnMessage = returnMessage.Replace("\r\n", "");
                    if (returnMessage == "Общий отдел")
                    {
                        UnitUserForm unitUserForm = new UnitUserForm();
                        unitUserForm.Show();
                        this.Hide();
                    }
                    else if (returnMessage == "Охрана")
                    {
                        DefenderUserForm defenderUserForm = new DefenderUserForm();
                        defenderUserForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Вы не работаете в отделе, которому разрешен доступ в систему.\nПроверьте код сотрудника или обратитесь к администратору за помощью", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный код сотрудника.\nПопробуйте авторизоваться ещё раз.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проблема с подключением к базе данных.\nПопробуйте авторизоваться ещё раз, если ошибка не пропадет - обратитесь к администратору","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
