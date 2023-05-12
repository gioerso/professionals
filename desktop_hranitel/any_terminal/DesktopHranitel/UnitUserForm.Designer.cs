namespace DesktopHranitel
{
    partial class UnitUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitUserForm));
            this.unitUserTabPage = new System.Windows.Forms.TabControl();
            this.CheckOrders = new System.Windows.Forms.TabPage();
            this.dataGridPage = new System.Windows.Forms.TabControl();
            this.groupPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupCheckButton = new System.Windows.Forms.Button();
            this.orderByComboBox = new System.Windows.Forms.Label();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.groupUsersDataGrid = new System.Windows.Forms.DataGridView();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onBlackListDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acceptedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usersgroupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.user06DataSet1 = new DesktopHranitel.User06DataSet1();
            this.privatePage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.privateCheckButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.orderComboBoxPrivate = new System.Windows.Forms.ComboBox();
            this.indDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.logoLabel = new System.Windows.Forms.Label();
            this.user06DataSet = new DesktopHranitel.User06DataSet();
            this.usersgroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_groupTableAdapter = new DesktopHranitel.User06DataSetTableAdapters.users_groupTableAdapter();
            this.user06DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_groupTableAdapter1 = new DesktopHranitel.User06DataSet1TableAdapters.users_groupTableAdapter();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.unitUserTabPage.SuspendLayout();
            this.CheckOrders.SuspendLayout();
            this.dataGridPage.SuspendLayout();
            this.groupPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersgroupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet1)).BeginInit();
            this.privatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersgroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // unitUserTabPage
            // 
            this.unitUserTabPage.Controls.Add(this.CheckOrders);
            this.unitUserTabPage.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitUserTabPage.Location = new System.Drawing.Point(12, 60);
            this.unitUserTabPage.Name = "unitUserTabPage";
            this.unitUserTabPage.SelectedIndex = 0;
            this.unitUserTabPage.Size = new System.Drawing.Size(776, 378);
            this.unitUserTabPage.TabIndex = 0;
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
            this.groupPage.Controls.Add(this.label1);
            this.groupPage.Controls.Add(this.GroupCheckButton);
            this.groupPage.Controls.Add(this.orderByComboBox);
            this.groupPage.Controls.Add(this.orderComboBox);
            this.groupPage.Controls.Add(this.groupUsersDataGrid);
            this.groupPage.Location = new System.Drawing.Point(4, 24);
            this.groupPage.Name = "groupPage";
            this.groupPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupPage.Size = new System.Drawing.Size(748, 312);
            this.groupPage.TabIndex = 0;
            this.groupPage.Text = "Групповые посещения";
            this.groupPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Проверить выбранного посетителя";
            // 
            // GroupCheckButton
            // 
            this.GroupCheckButton.Location = new System.Drawing.Point(182, 35);
            this.GroupCheckButton.Name = "GroupCheckButton";
            this.GroupCheckButton.Size = new System.Drawing.Size(194, 23);
            this.GroupCheckButton.TabIndex = 3;
            this.GroupCheckButton.Text = "Проверка";
            this.GroupCheckButton.UseVisualStyleBackColor = true;
            this.GroupCheckButton.Click += new System.EventHandler(this.GroupCheckButton_Click);
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.AutoSize = true;
            this.orderByComboBox.Location = new System.Drawing.Point(6, 17);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(94, 15);
            this.orderByComboBox.TabIndex = 2;
            this.orderByComboBox.Text = "Сортировать по:";
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "статусу",
            "подразделениям"});
            this.orderComboBox.Location = new System.Drawing.Point(6, 35);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(143, 23);
            this.orderComboBox.TabIndex = 1;
            this.orderComboBox.SelectedIndexChanged += new System.EventHandler(this.orderComboBox_SelectedIndexChanged);
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
            this.groupidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.onBlackListDataGridViewCheckBoxColumn,
            this.acceptedDataGridViewCheckBoxColumn});
            this.groupUsersDataGrid.DataSource = this.usersgroupBindingSource1;
            this.groupUsersDataGrid.GridColor = System.Drawing.Color.White;
            this.groupUsersDataGrid.Location = new System.Drawing.Point(6, 64);
            this.groupUsersDataGrid.Name = "groupUsersDataGrid";
            this.groupUsersDataGrid.Size = new System.Drawing.Size(736, 242);
            this.groupUsersDataGrid.TabIndex = 0;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.Width = 56;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 80;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 66;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 113;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.Width = 79;
            // 
            // groupidDataGridViewTextBoxColumn
            // 
            this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewTextBoxColumn.HeaderText = "ID группы";
            this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            this.groupidDataGridViewTextBoxColumn.Width = 89;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата посещения";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 120;
            // 
            // onBlackListDataGridViewCheckBoxColumn
            // 
            this.onBlackListDataGridViewCheckBoxColumn.DataPropertyName = "onBlackList";
            this.onBlackListDataGridViewCheckBoxColumn.HeaderText = "В черном листе?";
            this.onBlackListDataGridViewCheckBoxColumn.Name = "onBlackListDataGridViewCheckBoxColumn";
            this.onBlackListDataGridViewCheckBoxColumn.Width = 102;
            // 
            // acceptedDataGridViewCheckBoxColumn
            // 
            this.acceptedDataGridViewCheckBoxColumn.DataPropertyName = "accepted";
            this.acceptedDataGridViewCheckBoxColumn.HeaderText = "Доступ разрешен";
            this.acceptedDataGridViewCheckBoxColumn.Name = "acceptedDataGridViewCheckBoxColumn";
            this.acceptedDataGridViewCheckBoxColumn.Width = 104;
            // 
            // usersgroupBindingSource1
            // 
            this.usersgroupBindingSource1.DataMember = "users_group";
            this.usersgroupBindingSource1.DataSource = this.user06DataSet1;
            // 
            // user06DataSet1
            // 
            this.user06DataSet1.DataSetName = "User06DataSet1";
            this.user06DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // privatePage
            // 
            this.privatePage.Controls.Add(this.label2);
            this.privatePage.Controls.Add(this.privateCheckButton);
            this.privatePage.Controls.Add(this.label3);
            this.privatePage.Controls.Add(this.orderComboBoxPrivate);
            this.privatePage.Controls.Add(this.indDataGrid);
            this.privatePage.Location = new System.Drawing.Point(4, 24);
            this.privatePage.Name = "privatePage";
            this.privatePage.Padding = new System.Windows.Forms.Padding(3);
            this.privatePage.Size = new System.Drawing.Size(748, 312);
            this.privatePage.TabIndex = 1;
            this.privatePage.Text = "Индивидуальные посещения";
            this.privatePage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Проверить выбранного посетителя";
            // 
            // privateCheckButton
            // 
            this.privateCheckButton.Location = new System.Drawing.Point(182, 35);
            this.privateCheckButton.Name = "privateCheckButton";
            this.privateCheckButton.Size = new System.Drawing.Size(194, 23);
            this.privateCheckButton.TabIndex = 7;
            this.privateCheckButton.Text = "Проверка";
            this.privateCheckButton.UseVisualStyleBackColor = true;
            this.privateCheckButton.Click += new System.EventHandler(this.privateCheckButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сортировать по:";
            // 
            // orderComboBoxPrivate
            // 
            this.orderComboBoxPrivate.FormattingEnabled = true;
            this.orderComboBoxPrivate.Items.AddRange(new object[] {
            "статусу",
            "подразделениям"});
            this.orderComboBoxPrivate.Location = new System.Drawing.Point(6, 35);
            this.orderComboBoxPrivate.Name = "orderComboBoxPrivate";
            this.orderComboBoxPrivate.Size = new System.Drawing.Size(143, 23);
            this.orderComboBoxPrivate.TabIndex = 5;
            this.orderComboBoxPrivate.SelectedIndexChanged += new System.EventHandler(this.orderComboBoxPrivate_SelectedIndexChanged);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.indDataGrid.DataSource = this.usersgroupBindingSource1;
            this.indDataGrid.GridColor = System.Drawing.Color.White;
            this.indDataGrid.Location = new System.Drawing.Point(3, 64);
            this.indDataGrid.Name = "indDataGrid";
            this.indDataGrid.Size = new System.Drawing.Size(736, 242);
            this.indDataGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fio";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 56;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn2.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn3.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "birthday";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 113;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "passport";
            this.dataGridViewTextBoxColumn5.HeaderText = "Паспорт";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 79;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "group_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID группы";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 89;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата посещения";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "onBlackList";
            this.dataGridViewCheckBoxColumn1.HeaderText = "В черном листе?";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 102;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "accepted";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Доступ разрешен";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 104;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(10)))));
            this.logoLabel.Location = new System.Drawing.Point(72, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(562, 30);
            this.logoLabel.TabIndex = 2;
            this.logoLabel.Text = "ХранительПро - Панель сотрудника общего отдела";
            // 
            // user06DataSet
            // 
            this.user06DataSet.DataSetName = "User06DataSet";
            this.user06DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersgroupBindingSource
            // 
            this.usersgroupBindingSource.DataMember = "users_group";
            this.usersgroupBindingSource.DataSource = this.user06DataSet;
            // 
            // users_groupTableAdapter
            // 
            this.users_groupTableAdapter.ClearBeforeFill = true;
            // 
            // user06DataSetBindingSource
            // 
            this.user06DataSetBindingSource.DataSource = this.user06DataSet;
            this.user06DataSetBindingSource.Position = 0;
            // 
            // users_groupTableAdapter1
            // 
            this.users_groupTableAdapter1.ClearBeforeFill = true;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::DesktopHranitel.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(54, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "photo";
            this.dataGridViewImageColumn1.HeaderText = "Фотография";
            this.dataGridViewImageColumn1.Image = global::DesktopHranitel.Properties.Resources.User;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // UnitUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.unitUserTabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnitUserForm";
            this.Text = "ХранительПро - Сотрудник общего отдела";
            this.Load += new System.EventHandler(this.UnitUserForm_Load);
            this.unitUserTabPage.ResumeLayout(false);
            this.CheckOrders.ResumeLayout(false);
            this.dataGridPage.ResumeLayout(false);
            this.groupPage.ResumeLayout(false);
            this.groupPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersgroupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet1)).EndInit();
            this.privatePage.ResumeLayout(false);
            this.privatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersgroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user06DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl unitUserTabPage;
        private System.Windows.Forms.TabPage CheckOrders;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.TabControl dataGridPage;
        private System.Windows.Forms.TabPage groupPage;
        private System.Windows.Forms.TabPage privatePage;
        private System.Windows.Forms.DataGridView groupUsersDataGrid;
        private User06DataSet user06DataSet;
        private System.Windows.Forms.BindingSource usersgroupBindingSource;
        private User06DataSetTableAdapters.users_groupTableAdapter users_groupTableAdapter;
        private System.Windows.Forms.BindingSource user06DataSetBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private User06DataSet1 user06DataSet1;
        private System.Windows.Forms.BindingSource usersgroupBindingSource1;
        private User06DataSet1TableAdapters.users_groupTableAdapter users_groupTableAdapter1;
        private System.Windows.Forms.Label orderByComboBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GroupCheckButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button privateCheckButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orderComboBoxPrivate;
        private System.Windows.Forms.DataGridView indDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onBlackListDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}