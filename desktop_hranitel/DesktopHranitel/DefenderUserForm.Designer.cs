namespace DesktopHranitel
{
    partial class DefenderUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefenderUserForm));
            this.logoLabel = new System.Windows.Forms.Label();
            this.unitUserTabPage = new System.Windows.Forms.TabControl();
            this.CheckOrders = new System.Windows.Forms.TabPage();
            this.dataGridPage = new System.Windows.Forms.TabControl();
            this.groupPage = new System.Windows.Forms.TabPage();
            this.aboutUserGroupButton = new System.Windows.Forms.Button();
            this.findGroupButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupPassportTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupFIOTextBox = new System.Windows.Forms.TextBox();
            this.groupUsersDataGrid = new System.Windows.Forms.DataGridView();
            this.fioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onBlackListDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acceptedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usersgroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user06DataSet3 = new DesktopHranitel.User06DataSet3();
            this.privatePage = new System.Windows.Forms.TabPage();
            this.aboutUserPrivateButton = new System.Windows.Forms.Button();
            this.indEntryFindButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.indPassportTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.indFioTextBox = new System.Windows.Forms.TextBox();
            this.indDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onBlackListDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acceptedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usersprivateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user06DataSet2 = new DesktopHranitel.User06DataSet2();
            this.users_privateTableAdapter = new DesktopHranitel.User06DataSet2TableAdapters.users_privateTableAdapter();
            this.users_groupTableAdapter = new DesktopHranitel.User06DataSet3TableAdapters.users_groupTableAdapter();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.unitUserTabPage.SuspendLayout();
            this.CheckOrders.SuspendLayout();
            this.dataGridPage.SuspendLayout();
            this.groupPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersgroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet3)).BeginInit();
            this.privatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(10)))));
            this.logoLabel.Location = new System.Drawing.Point(70, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(564, 30);
            this.logoLabel.TabIndex = 4;
            this.logoLabel.Text = "ХранительПро - Панель сотрудника отдела охраны";
            // 
            // unitUserTabPage
            // 
            this.unitUserTabPage.Controls.Add(this.CheckOrders);
            this.unitUserTabPage.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitUserTabPage.Location = new System.Drawing.Point(10, 60);
            this.unitUserTabPage.Name = "unitUserTabPage";
            this.unitUserTabPage.SelectedIndex = 0;
            this.unitUserTabPage.Size = new System.Drawing.Size(776, 378);
            this.unitUserTabPage.TabIndex = 5;
            // 
            // CheckOrders
            // 
            this.CheckOrders.Controls.Add(this.dataGridPage);
            this.CheckOrders.Location = new System.Drawing.Point(4, 24);
            this.CheckOrders.Name = "CheckOrders";
            this.CheckOrders.Padding = new System.Windows.Forms.Padding(3);
            this.CheckOrders.Size = new System.Drawing.Size(768, 350);
            this.CheckOrders.TabIndex = 0;
            this.CheckOrders.Text = "Просмотр списка заявок";
            this.CheckOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridPage
            // 
            this.dataGridPage.Controls.Add(this.groupPage);
            this.dataGridPage.Controls.Add(this.privatePage);
            this.dataGridPage.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridPage.Location = new System.Drawing.Point(6, 6);
            this.dataGridPage.Name = "dataGridPage";
            this.dataGridPage.SelectedIndex = 0;
            this.dataGridPage.Size = new System.Drawing.Size(756, 340);
            this.dataGridPage.TabIndex = 0;
            // 
            // groupPage
            // 
            this.groupPage.Controls.Add(this.aboutUserGroupButton);
            this.groupPage.Controls.Add(this.findGroupButton);
            this.groupPage.Controls.Add(this.label5);
            this.groupPage.Controls.Add(this.groupPassportTextBox);
            this.groupPage.Controls.Add(this.label4);
            this.groupPage.Controls.Add(this.label1);
            this.groupPage.Controls.Add(this.groupFIOTextBox);
            this.groupPage.Controls.Add(this.groupUsersDataGrid);
            this.groupPage.Location = new System.Drawing.Point(4, 24);
            this.groupPage.Name = "groupPage";
            this.groupPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupPage.Size = new System.Drawing.Size(748, 312);
            this.groupPage.TabIndex = 0;
            this.groupPage.Text = "Групповые посещения";
            this.groupPage.UseVisualStyleBackColor = true;
            // 
            // aboutUserGroupButton
            // 
            this.aboutUserGroupButton.Location = new System.Drawing.Point(630, 17);
            this.aboutUserGroupButton.Name = "aboutUserGroupButton";
            this.aboutUserGroupButton.Size = new System.Drawing.Size(87, 41);
            this.aboutUserGroupButton.TabIndex = 7;
            this.aboutUserGroupButton.Text = "Подробнее о посетителе";
            this.aboutUserGroupButton.UseVisualStyleBackColor = true;
            this.aboutUserGroupButton.Click += new System.EventHandler(this.aboutUserGroupButton_Click);
            // 
            // findGroupButton
            // 
            this.findGroupButton.Location = new System.Drawing.Point(549, 17);
            this.findGroupButton.Name = "findGroupButton";
            this.findGroupButton.Size = new System.Drawing.Size(75, 41);
            this.findGroupButton.TabIndex = 6;
            this.findGroupButton.Text = "Найти";
            this.findGroupButton.UseVisualStyleBackColor = true;
            this.findGroupButton.Click += new System.EventHandler(this.findGroupButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Серии и номеру паспорта";
            // 
            // groupPassportTextBox
            // 
            this.groupPassportTextBox.Location = new System.Drawing.Point(320, 27);
            this.groupPassportTextBox.Name = "groupPassportTextBox";
            this.groupPassportTextBox.Size = new System.Drawing.Size(206, 23);
            this.groupPassportTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск по:";
            // 
            // groupFIOTextBox
            // 
            this.groupFIOTextBox.Location = new System.Drawing.Point(94, 27);
            this.groupFIOTextBox.Name = "groupFIOTextBox";
            this.groupFIOTextBox.Size = new System.Drawing.Size(206, 23);
            this.groupFIOTextBox.TabIndex = 1;
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
            this.fioDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.birthdayDataGridViewTextBoxColumn1,
            this.passportDataGridViewTextBoxColumn1,
            this.loginDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.groupidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1,
            this.onBlackListDataGridViewCheckBoxColumn1,
            this.acceptedDataGridViewCheckBoxColumn1});
            this.groupUsersDataGrid.DataSource = this.usersgroupBindingSource;
            this.groupUsersDataGrid.GridColor = System.Drawing.Color.White;
            this.groupUsersDataGrid.Location = new System.Drawing.Point(6, 64);
            this.groupUsersDataGrid.Name = "groupUsersDataGrid";
            this.groupUsersDataGrid.Size = new System.Drawing.Size(736, 242);
            this.groupUsersDataGrid.TabIndex = 0;
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
            // groupidDataGridViewTextBoxColumn
            // 
            this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewTextBoxColumn.HeaderText = "group_id";
            this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            this.groupidDataGridViewTextBoxColumn.Width = 78;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 54;
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
            // usersgroupBindingSource
            // 
            this.usersgroupBindingSource.DataMember = "users_group";
            this.usersgroupBindingSource.DataSource = this.user06DataSet3;
            // 
            // user06DataSet3
            // 
            this.user06DataSet3.DataSetName = "User06DataSet3";
            this.user06DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // privatePage
            // 
            this.privatePage.Controls.Add(this.aboutUserPrivateButton);
            this.privatePage.Controls.Add(this.indEntryFindButton);
            this.privatePage.Controls.Add(this.label2);
            this.privatePage.Controls.Add(this.indPassportTextBox);
            this.privatePage.Controls.Add(this.label3);
            this.privatePage.Controls.Add(this.label6);
            this.privatePage.Controls.Add(this.indFioTextBox);
            this.privatePage.Controls.Add(this.indDataGrid);
            this.privatePage.Location = new System.Drawing.Point(4, 24);
            this.privatePage.Name = "privatePage";
            this.privatePage.Padding = new System.Windows.Forms.Padding(3);
            this.privatePage.Size = new System.Drawing.Size(748, 312);
            this.privatePage.TabIndex = 1;
            this.privatePage.Text = "Индивидуальные посещения";
            this.privatePage.UseVisualStyleBackColor = true;
            // 
            // aboutUserPrivateButton
            // 
            this.aboutUserPrivateButton.Location = new System.Drawing.Point(640, 11);
            this.aboutUserPrivateButton.Name = "aboutUserPrivateButton";
            this.aboutUserPrivateButton.Size = new System.Drawing.Size(87, 41);
            this.aboutUserPrivateButton.TabIndex = 14;
            this.aboutUserPrivateButton.Text = "Подробнее о посетителе";
            this.aboutUserPrivateButton.UseVisualStyleBackColor = true;
            this.aboutUserPrivateButton.Click += new System.EventHandler(this.aboutUserPrivateButton_Click);
            // 
            // indEntryFindButton
            // 
            this.indEntryFindButton.Location = new System.Drawing.Point(559, 11);
            this.indEntryFindButton.Name = "indEntryFindButton";
            this.indEntryFindButton.Size = new System.Drawing.Size(75, 41);
            this.indEntryFindButton.TabIndex = 13;
            this.indEntryFindButton.Text = "Найти";
            this.indEntryFindButton.UseVisualStyleBackColor = true;
            this.indEntryFindButton.Click += new System.EventHandler(this.indEntryFindButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Серии и номеру паспорта";
            // 
            // indPassportTextBox
            // 
            this.indPassportTextBox.Location = new System.Drawing.Point(330, 21);
            this.indPassportTextBox.Name = "indPassportTextBox";
            this.indPassportTextBox.Size = new System.Drawing.Size(206, 23);
            this.indPassportTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Поиск по:";
            // 
            // indFioTextBox
            // 
            this.indFioTextBox.Location = new System.Drawing.Point(104, 21);
            this.indFioTextBox.Name = "indFioTextBox";
            this.indFioTextBox.Size = new System.Drawing.Size(206, 23);
            this.indFioTextBox.TabIndex = 8;
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
            this.fioDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.organizationDataGridViewTextBoxColumn,
            this.onBlackListDataGridViewCheckBoxColumn,
            this.acceptedDataGridViewCheckBoxColumn});
            this.indDataGrid.DataSource = this.usersprivateBindingSource;
            this.indDataGrid.GridColor = System.Drawing.Color.White;
            this.indDataGrid.Location = new System.Drawing.Point(3, 64);
            this.indDataGrid.Name = "indDataGrid";
            this.indDataGrid.Size = new System.Drawing.Size(736, 242);
            this.indDataGrid.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 42;
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
            // usersprivateBindingSource
            // 
            this.usersprivateBindingSource.DataMember = "users_private";
            this.usersprivateBindingSource.DataSource = this.user06DataSet2;
            // 
            // user06DataSet2
            // 
            this.user06DataSet2.DataSetName = "User06DataSet2";
            this.user06DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // users_privateTableAdapter
            // 
            this.users_privateTableAdapter.ClearBeforeFill = true;
            // 
            // users_groupTableAdapter
            // 
            this.users_groupTableAdapter.ClearBeforeFill = true;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::DesktopHranitel.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(10, 4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(54, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // DefenderUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unitUserTabPage);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefenderUserForm";
            this.Text = "ХранительПро - Охрана";
            this.Load += new System.EventHandler(this.DefenderUserForm_Load);
            this.unitUserTabPage.ResumeLayout(false);
            this.CheckOrders.ResumeLayout(false);
            this.dataGridPage.ResumeLayout(false);
            this.groupPage.ResumeLayout(false);
            this.groupPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersgroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet3)).EndInit();
            this.privatePage.ResumeLayout(false);
            this.privatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TabControl unitUserTabPage;
        private System.Windows.Forms.TabPage CheckOrders;
        private System.Windows.Forms.TabControl dataGridPage;
        private System.Windows.Forms.TabPage groupPage;
        private System.Windows.Forms.DataGridView groupUsersDataGrid;
        private System.Windows.Forms.TabPage privatePage;
        private System.Windows.Forms.DataGridView indDataGrid;
        private System.Windows.Forms.Button aboutUserGroupButton;
        private System.Windows.Forms.Button findGroupButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox groupPassportTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox groupFIOTextBox;
        private System.Windows.Forms.Button aboutUserPrivateButton;
        private System.Windows.Forms.Button indEntryFindButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox indPassportTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox indFioTextBox;
        private User06DataSet2 user06DataSet2;
        private System.Windows.Forms.BindingSource usersprivateBindingSource;
        private User06DataSet2TableAdapters.users_privateTableAdapter users_privateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onBlackListDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptedDataGridViewCheckBoxColumn;
        private User06DataSet3 user06DataSet3;
        private System.Windows.Forms.BindingSource usersgroupBindingSource;
        private User06DataSet3TableAdapters.users_groupTableAdapter users_groupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onBlackListDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptedDataGridViewCheckBoxColumn1;
    }
}