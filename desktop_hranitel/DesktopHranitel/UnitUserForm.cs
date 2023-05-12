using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopHranitel
{
    /// <summary>
    /// Форма для сотрудника общего отдела
    /// </summary>
    public partial class UnitUserForm : Form
    {
        public UnitUserForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Функция при событии загрузки формы
        /// </summary>
        private void UnitUserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user06DataSet1.users_group". При необходимости она может быть перемещена или удалена.
            this.users_groupTableAdapter1.Fill(this.user06DataSet1.users_group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user06DataSet.users_group". При необходимости она может быть перемещена или удалена.
            this.users_groupTableAdapter.Fill(this.user06DataSet.users_group);

            for (int i = 0; i < groupUsersDataGrid.Rows.Count - 1; i++)
            {
                if (groupUsersDataGrid.Rows[i].Cells[7].Value.ToString() == "True")
                {
                    DataGridViewCellStyle dgStyle = new DataGridViewCellStyle();
                    dgStyle.BackColor = Color.Red;
                    groupUsersDataGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            
            for (int i = 0; i < indDataGrid.Rows.Count - 1; i++)
            {
                if (indDataGrid.Rows[i].Cells[7].Value.ToString() == "True")
                {
                    indDataGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        /// <summary>
        /// Код, исполняемый при сортировке
        /// </summary>
        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderByComboBox.Text == "статусу")
            {
                SQL LibSql = new SQL();
                DataTable dt = LibSql.ReturnDataTable($"select fio,phone,email,birthday,passport,(SELECT group_name FROM groups WHERE users_group.group_id = groups.id), date,onBlackList, accepted from users_group order by accepted desc ");

                groupUsersDataGrid.DataSource = dt;
            }

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
        /// Код, исполняемый при сортировке
        /// </summary>
        private void orderComboBoxPrivate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderByComboBox.Text == "статусу")
            {
                SQL LibSql = new SQL();
                DataTable dt = LibSql.ReturnDataTable($"SELECT fio,phone,email,birthday,passport, date,onBlackList, accepted FROM users_private order by accepted desc ");

                groupUsersDataGrid.DataSource = dt;


                for (int i = 0; i < indDataGrid.Rows.Count - 1; i++)
                {
                    if (indDataGrid.Rows[i].Cells[7].Value.ToString() == "True")
                    {
                        indDataGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
        /// <summary>
        /// Кнопка для просмотра подробной информации о человеке
        /// </summary>
        private void privateCheckButton_Click(object sender, EventArgs e)
        {
            indEntryForm indEntryForm = new indEntryForm();
            indEntryForm.Show();
        }
        /// <summary>
        /// Кнопка для просмотра подробной информации о человеке
        /// </summary>
        private void GroupCheckButton_Click(object sender, EventArgs e)
        {
            indEntryForm indEntryForm = new indEntryForm();
            indEntryForm.Show();
        }
    }
}
