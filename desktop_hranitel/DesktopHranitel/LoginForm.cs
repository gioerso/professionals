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
                    SqlCommand cmd3 = new SqlCommand($"SELECT unit FROM employers where user_code = '{loginTextBox.Text}';", conn);
                    string _subUnit = cmd3.ExecuteScalar().ToString();
                    if (_subUnit != "") { 
                        SubUnitUserForm subUnitForm = new SubUnitUserForm();
                        subUnitForm.Show();
                        this.Hide();
                    }
                    else if (returnMessage == "Общий отдел")
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
                }
                else
                {
                    MessageBox.Show("Неправильный код сотрудника.\nПопробуйте авторизоваться ещё раз.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с подключением к базе данных.\nПопробуйте авторизоваться ещё раз, если ошибка не пропадет - обратитесь к администратору","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
