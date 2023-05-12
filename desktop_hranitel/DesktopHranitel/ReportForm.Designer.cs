namespace DesktopHranitel
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.logoLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dateEneringGroupOrderByDate = new System.Windows.Forms.TabControl();
            this.groupPage = new System.Windows.Forms.TabPage();
            this.groupUsersDataGrid = new System.Windows.Forms.DataGridView();
            this.privatePage = new System.Windows.Forms.TabPage();
            this.indDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.user06DataSet4 = new DesktopHranitel.User06DataSet4();
            this.usersgroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_groupTableAdapter = new DesktopHranitel.User06DataSet4TableAdapters.users_groupTableAdapter();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onBlackListDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acceptedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.user06DataSet5 = new DesktopHranitel.User06DataSet5();
            this.usersprivateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_privateTableAdapter = new DesktopHranitel.User06DataSet5TableAdapters.users_privateTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onBlackListDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acceptedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.dateEneringGroupOrderByDate.SuspendLayout();
            this.groupPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersDataGrid)).BeginInit();
            this.privatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersgroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(10)))));
            this.logoLabel.Location = new System.Drawing.Point(72, 17);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(272, 30);
            this.logoLabel.TabIndex = 8;
            this.logoLabel.Text = "ХранительПро - Отчеты";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::DesktopHranitel.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(54, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 7;
            this.logoPictureBox.TabStop = false;
            // 
            // dateEneringGroupOrderByDate
            // 
            this.dateEneringGroupOrderByDate.Controls.Add(this.groupPage);
            this.dateEneringGroupOrderByDate.Controls.Add(this.privatePage);
            this.dateEneringGroupOrderByDate.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEneringGroupOrderByDate.Location = new System.Drawing.Point(12, 68);
            this.dateEneringGroupOrderByDate.Name = "dateEneringGroupOrderByDate";
            this.dateEneringGroupOrderByDate.SelectedIndex = 0;
            this.dateEneringGroupOrderByDate.Size = new System.Drawing.Size(776, 370);
            this.dateEneringGroupOrderByDate.TabIndex = 9;
            // 
            // groupPage
            // 
            this.groupPage.Controls.Add(this.button1);
            this.groupPage.Controls.Add(this.label1);
            this.groupPage.Controls.Add(this.groupUsersDataGrid);
            this.groupPage.Location = new System.Drawing.Point(4, 24);
            this.groupPage.Name = "groupPage";
            this.groupPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupPage.Size = new System.Drawing.Size(768, 342);
            this.groupPage.TabIndex = 0;
            this.groupPage.Text = "Отчет по групповым посещениям";
            this.groupPage.UseVisualStyleBackColor = true;
            // 
            // groupUsersDataGrid
            // 
            this.groupUsersDataGrid.AutoGenerateColumns = false;
            this.groupUsersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.groupUsersDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.groupUsersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.groupUsersDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.groupUsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.groupUsersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.onBlackListDataGridViewCheckBoxColumn,
            this.acceptedDataGridViewCheckBoxColumn});
            this.groupUsersDataGrid.DataSource = this.usersgroupBindingSource;
            this.groupUsersDataGrid.GridColor = System.Drawing.Color.White;
            this.groupUsersDataGrid.Location = new System.Drawing.Point(3, 38);
            this.groupUsersDataGrid.Name = "groupUsersDataGrid";
            this.groupUsersDataGrid.Size = new System.Drawing.Size(756, 298);
            this.groupUsersDataGrid.TabIndex = 0;
            // 
            // privatePage
            // 
            this.privatePage.Controls.Add(this.button3);
            this.privatePage.Controls.Add(this.button2);
            this.privatePage.Controls.Add(this.label2);
            this.privatePage.Controls.Add(this.indDataGrid);
            this.privatePage.Location = new System.Drawing.Point(4, 24);
            this.privatePage.Name = "privatePage";
            this.privatePage.Padding = new System.Windows.Forms.Padding(3);
            this.privatePage.Size = new System.Drawing.Size(768, 342);
            this.privatePage.TabIndex = 1;
            this.privatePage.Text = "Отчет по индивидуальным посещениям";
            this.privatePage.UseVisualStyleBackColor = true;
            // 
            // indDataGrid
            // 
            this.indDataGrid.AutoGenerateColumns = false;
            this.indDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.indDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.indDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.indDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.indDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.indDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.birthdayDataGridViewTextBoxColumn1,
            this.passportDataGridViewTextBoxColumn1,
            this.loginDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.commentsDataGridViewTextBoxColumn,
            this.organizationDataGridViewTextBoxColumn,
            this.onBlackListDataGridViewCheckBoxColumn1,
            this.acceptedDataGridViewCheckBoxColumn1});
            this.indDataGrid.DataSource = this.usersprivateBindingSource;
            this.indDataGrid.GridColor = System.Drawing.Color.White;
            this.indDataGrid.Location = new System.Drawing.Point(6, 39);
            this.indDataGrid.Name = "indDataGrid";
            this.indDataGrid.Size = new System.Drawing.Size(756, 297);
            this.indDataGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Посетителей всего: 15";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить таблицу в файл";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // user06DataSet4
            // 
            this.user06DataSet4.DataSetName = "User06DataSet4";
            this.user06DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersgroupBindingSource
            // 
            this.usersgroupBindingSource.DataMember = "users_group";
            this.usersgroupBindingSource.DataSource = this.user06DataSet4;
            // 
            // users_groupTableAdapter
            // 
            this.users_groupTableAdapter.ClearBeforeFill = true;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "fio";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.Width = 48;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 62;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 59;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 75;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "passport";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.Width = 75;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 57;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 79;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 54;
            // 
            // onBlackListDataGridViewCheckBoxColumn
            // 
            this.onBlackListDataGridViewCheckBoxColumn.DataPropertyName = "onBlackList";
            this.onBlackListDataGridViewCheckBoxColumn.HeaderText = "onBlackList";
            this.onBlackListDataGridViewCheckBoxColumn.Name = "onBlackListDataGridViewCheckBoxColumn";
            this.onBlackListDataGridViewCheckBoxColumn.Width = 72;
            // 
            // acceptedDataGridViewCheckBoxColumn
            // 
            this.acceptedDataGridViewCheckBoxColumn.DataPropertyName = "accepted";
            this.acceptedDataGridViewCheckBoxColumn.HeaderText = "accepted";
            this.acceptedDataGridViewCheckBoxColumn.Name = "acceptedDataGridViewCheckBoxColumn";
            this.acceptedDataGridViewCheckBoxColumn.Width = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Посетителей всего: 15";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить таблицу в файл";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // user06DataSet5
            // 
            this.user06DataSet5.DataSetName = "User06DataSet5";
            this.user06DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersprivateBindingSource
            // 
            this.usersprivateBindingSource.DataMember = "users_private";
            this.usersprivateBindingSource.DataSource = this.user06DataSet5;
            // 
            // users_privateTableAdapter
            // 
            this.users_privateTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 42;
            // 
            // fioDataGridViewTextBoxColumn1
            // 
            this.fioDataGridViewTextBoxColumn1.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn1.HeaderText = "fio";
            this.fioDataGridViewTextBoxColumn1.Name = "fioDataGridViewTextBoxColumn1";
            this.fioDataGridViewTextBoxColumn1.Width = 48;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.Width = 62;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 59;
            // 
            // birthdayDataGridViewTextBoxColumn1
            // 
            this.birthdayDataGridViewTextBoxColumn1.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn1.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn1.Name = "birthdayDataGridViewTextBoxColumn1";
            this.birthdayDataGridViewTextBoxColumn1.Width = 75;
            // 
            // passportDataGridViewTextBoxColumn1
            // 
            this.passportDataGridViewTextBoxColumn1.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn1.HeaderText = "passport";
            this.passportDataGridViewTextBoxColumn1.Name = "passportDataGridViewTextBoxColumn1";
            this.passportDataGridViewTextBoxColumn1.Width = 75;
            // 
            // loginDataGridViewTextBoxColumn1
            // 
            this.loginDataGridViewTextBoxColumn1.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn1.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn1.Name = "loginDataGridViewTextBoxColumn1";
            this.loginDataGridViewTextBoxColumn1.Width = 57;
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            this.passwordDataGridViewTextBoxColumn1.Width = 79;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 54;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.Width = 81;
            // 
            // organizationDataGridViewTextBoxColumn
            // 
            this.organizationDataGridViewTextBoxColumn.DataPropertyName = "organization";
            this.organizationDataGridViewTextBoxColumn.HeaderText = "organization";
            this.organizationDataGridViewTextBoxColumn.Name = "organizationDataGridViewTextBoxColumn";
            this.organizationDataGridViewTextBoxColumn.Width = 97;
            // 
            // onBlackListDataGridViewCheckBoxColumn1
            // 
            this.onBlackListDataGridViewCheckBoxColumn1.DataPropertyName = "onBlackList";
            this.onBlackListDataGridViewCheckBoxColumn1.HeaderText = "onBlackList";
            this.onBlackListDataGridViewCheckBoxColumn1.Name = "onBlackListDataGridViewCheckBoxColumn1";
            this.onBlackListDataGridViewCheckBoxColumn1.Width = 72;
            // 
            // acceptedDataGridViewCheckBoxColumn1
            // 
            this.acceptedDataGridViewCheckBoxColumn1.DataPropertyName = "accepted";
            this.acceptedDataGridViewCheckBoxColumn1.HeaderText = "accepted";
            this.acceptedDataGridViewCheckBoxColumn1.Name = "acceptedDataGridViewCheckBoxColumn1";
            this.acceptedDataGridViewCheckBoxColumn1.Width = 59;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(295, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Вывести людей, находящихся на предприятии";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateEneringGroupOrderByDate);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "ХранительПро - Отчеты";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.dateEneringGroupOrderByDate.ResumeLayout(false);
            this.groupPage.ResumeLayout(false);
            this.groupPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersDataGrid)).EndInit();
            this.privatePage.ResumeLayout(false);
            this.privatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersgroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TabControl dateEneringGroupOrderByDate;
        private System.Windows.Forms.TabPage groupPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView groupUsersDataGrid;
        private System.Windows.Forms.TabPage privatePage;
        private System.Windows.Forms.DataGridView indDataGrid;
        private System.Windows.Forms.Button button1;
        private User06DataSet4 user06DataSet4;
        private System.Windows.Forms.BindingSource usersgroupBindingSource;
        private User06DataSet4TableAdapters.users_groupTableAdapter users_groupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onBlackListDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private User06DataSet5 user06DataSet5;
        private System.Windows.Forms.BindingSource usersprivateBindingSource;
        private User06DataSet5TableAdapters.users_privateTableAdapter users_privateTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onBlackListDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptedDataGridViewCheckBoxColumn1;
    }
}