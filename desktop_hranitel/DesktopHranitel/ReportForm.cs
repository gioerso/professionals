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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user06DataSet5.users_private". При необходимости она может быть перемещена или удалена.
            this.users_privateTableAdapter.Fill(this.user06DataSet5.users_private);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user06DataSet4.users_group". При необходимости она может быть перемещена или удалена.
            this.users_groupTableAdapter.Fill(this.user06DataSet4.users_group);

        }
    }
}
