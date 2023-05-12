using SQLLib;
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

namespace Straznik
{
    public partial class EntryAdminForm : Form
    {
        Byte[] bytes;
        /// <summary>
        /// Проверка на двойное нажатие
        /// </summary>
        bool dualClick = false;
        /// <summary>
        /// Библиотека для SQL запросов
        /// </summary>
        SQL _sql = new SQL();
        /// <summary>
        /// Форма Администратора доступа
        /// </summary>
        public EntryAdminForm()
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
        /// Действия по кнопке ExitButton
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Действия по кнопке saveUserButton
        /// </summary>
        private void saveUserButton_Click(object sender, EventArgs e)
        {
            if(dualClick == true)
            {
                MessageBox.Show("Система заблокированна на 10 секунд");
                _sql.ExecuteNonQuery($"update users set blocked = '1' where login = '{LoginForm.login}'");
                Task.Delay(10000).Wait();
                _sql.ExecuteNonQuery($"update users set blocked = '0' where login = '{LoginForm.login}'");
                dualClick = false;
            }
            if(LastNameTextBox.Text != "" && MiddleNameTextBox.Text != "")
            {
                string fio = LastNameTextBox.Text + " " + FirstNameTextBox.Text + " " + MiddleNameTextBox.Text;
                string sex;
                if (sexComboBox.SelectedIndex == 0)
                {
                    sex = "М";
                }
                else
                {
                    sex = "Ж";
                }
                _sql.ExecuteNonQuery($"INSERT INTO users (fio,sex,position,type_id) VALUES ('{fio}','{sex}','{positionTextBox.Text}','7')");

                LastNameTextBox.Text = "";
                FirstNameTextBox.Text = "";
                MiddleNameTextBox.Text = "";
                sexComboBox.Text = "";
                positionTextBox.Text = "";
                MessageBox.Show("Данные успешно сохранены!");
            }
            else
            {
                dualClick = true;
            }
        }
        /// <summary>
        /// Действия по кнопке cancelUserButton
        /// </summary>
        private void cancelUserButton_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            MiddleNameTextBox.Text = "";
            sexComboBox.Text = "";
            positionTextBox.Text = "";
            photoImage.Image = null;
        }
        /// <summary>
        /// Действия при нажатии кнопки addPhotoButton
        /// </summary>
        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();

            try
            {
                if (fileDialog.FileName != "")
                {
                    string path = fileDialog.FileName;
                    FileStream fs;
                    using (fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        bytes = new byte[fs.Length];

                        fs.WriteAsync(bytes, 0, 0);
                        fs.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось записать фото в БД. Обратитесь к системному администратору","Ошибка!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
